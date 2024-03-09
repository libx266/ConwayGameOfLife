using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace ConwayGameOfLife
{
    public class ConwayFrame
    {
        public readonly ConwayConfig Config;
        private readonly byte[,] _dots;


        public ConwayFrame(ConwayConfig config)
        {
            _dots = new byte[config.Size.Width, config.Size.Height];

            var r = new Random(Convert.ToBoolean(config.Seed) ? config.Seed : Random.Shared.Next());
            for (int y = 0; y < config.Size.Height; y++)
            {
                for (int x = 0; x < config.Size.Width; x++)
                {
                    if (r.NextDouble() <= config.FirstGenAlive)
                    {
                        _dots[x, y] = 1;
                    }
                }
            }

            Config = config;
        }


        private ConwayFrame(byte[,] dots, ConwayConfig config)
        {
            _dots = dots;
            Config = config;
        }


        private IEnumerable<byte> GetScope(int x, int y)
        {
            int h = (Config.ScopeHeight - 1) / 2;
            int w = (Config.ScopeWidth - 1) / 2;

            for (int Y = y - h; Y <= y + h; Y++)
            {
                for (int X = x - w; X <= x + w; X++)
                {
                    if (X < 0 || Y < 0 || X >= Config.Size.Width || Y >= Config.Size.Height || (x == X && y == Y))
                    {
                        continue;
                    }
                    yield return _dots[X, Y];
                }
            }
        }


        public async Task<ConwayFrame> Next()
        {
            var newDots = new byte[Config.Size.Width, Config.Size.Height];
            var sem = new SemaphoreSlim(Environment.ProcessorCount - 1);

            await Task.WhenAll(Enumerable.Range(0, Config.Size.Height).Select(y => Task.Run(async () =>
            {
                await sem.WaitAsync();

                for (int x = 0; x < Config.Size.Width; x++)
                {
                    int aliveCount = GetScope(x, y).Count(d => Convert.ToBoolean(d));
                    bool currentAlive = Convert.ToBoolean(_dots[x, y]);

                    if (!currentAlive && (aliveCount >= Config.SpawnMin && aliveCount <= Config.SpawnMax))
                    {
                        newDots[x, y] = 1;
                    }
                    else if (currentAlive && (aliveCount >= Config.LiveMin && aliveCount <= Config.LiveMax))
                    {
                        newDots[x, y] = 1;
                    }
                    else
                    {
                        newDots[x, y] = 0;
                    }
                }

                sem.Release();
            })));

            return new ConwayFrame(newDots, Config);
        }


        public DirectBitmap Render(Color background, Color foreground)
        {
            var reult = new DirectBitmap(Config.Size.Width, Config.Size.Height);

            var c = new byte[2, 2];

            c[0, 0] = 0b0000_0000;
            c[0, 1] = 0b0000_1010;
            c[1, 0] = 0b1010_0000;
            c[1, 1] = 0b1010_1010;

            for (int y = 0; y < Config.Size.Height; y++)
            {
                for (int x = 0; x < Config.Size.Width; x += 64)
                {
                    reult.SetPixelAvx
                    (
                        x / 2, y,
                        c[_dots[x + 0, y], _dots[x + 1, y]],
                        c[_dots[x + 2, y], _dots[x + 3, y]],
                        c[_dots[x + 4, y], _dots[x + 5, y]],
                        c[_dots[x + 6, y], _dots[x + 7, y]],
                        c[_dots[x + 8, y], _dots[x + 9, y]],
                        c[_dots[x + 10, y], _dots[x + 11, y]],
                        c[_dots[x + 12, y], _dots[x + 13, y]],
                        c[_dots[x + 14, y], _dots[x + 15, y]],
                        c[_dots[x + 16, y], _dots[x + 17, y]],
                        c[_dots[x + 18, y], _dots[x + 19, y]],
                        c[_dots[x + 20, y], _dots[x + 21, y]],
                        c[_dots[x + 22, y], _dots[x + 23, y]],
                        c[_dots[x + 24, y], _dots[x + 25, y]],
                        c[_dots[x + 26, y], _dots[x + 27, y]],
                        c[_dots[x + 28, y], _dots[x + 29, y]],
                        c[_dots[x + 30, y], _dots[x + 31, y]],
                        c[_dots[x + 32, y], _dots[x + 33, y]],
                        c[_dots[x + 34, y], _dots[x + 35, y]],
                        c[_dots[x + 36, y], _dots[x + 37, y]],
                        c[_dots[x + 38, y], _dots[x + 39, y]],
                        c[_dots[x + 40, y], _dots[x + 41, y]],
                        c[_dots[x + 42, y], _dots[x + 43, y]],
                        c[_dots[x + 44, y], _dots[x + 45, y]],
                        c[_dots[x + 46, y], _dots[x + 47, y]],
                        c[_dots[x + 48, y], _dots[x + 49, y]],
                        c[_dots[x + 50, y], _dots[x + 51, y]],
                        c[_dots[x + 52, y], _dots[x + 53, y]],
                        c[_dots[x + 54, y], _dots[x + 55, y]],
                        c[_dots[x + 56, y], _dots[x + 57, y]],
                        c[_dots[x + 58, y], _dots[x + 59, y]],
                        c[_dots[x + 60, y], _dots[x + 61, y]],
                        c[_dots[x + 62, y], _dots[x + 63, y]]
                    );
                }
            }

            return reult;
        }
    }
}
