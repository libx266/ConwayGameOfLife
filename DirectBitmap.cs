using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public class DirectBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        private byte[] Bits { get; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new byte[width * height / 2];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width / 2, PixelFormat.Format4bppIndexed, BitsHandle.AddrOfPinnedObject());
        }


        public unsafe void SetPixelAvx
        (
            int x_start, int y,
            byte c1, byte c2, byte c3, byte c4, byte c5, byte c6, byte c7, byte c8,
            byte c9, byte c10, byte c11, byte c12, byte c13, byte c14, byte c15, byte c16,
            byte c17, byte c18, byte c19, byte c20, byte c21, byte c22, byte c23, byte c24,
            byte c25, byte c26, byte c27, byte c28, byte c29, byte c30, byte c31, byte c32
        )
        {
            int index = x_start + (y * Width / 2);


            var colors = Vector256.Create(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26, c27, c28, c29, c30, c31, c32);
            fixed (byte* pBits = &Bits[index])
            {
                Avx2.Store(pBits, colors);
            }
        }


        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }
    }
}
