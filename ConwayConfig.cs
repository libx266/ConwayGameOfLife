using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public record ConwayConfig
    (
        byte SpawnMin,
        byte SpawnMax,
        byte LiveMin,
        byte LiveMax,
        byte ScopeWidth,
        byte ScopeHeight,
        int Seed,
        float FirstGenAlive,
        Size Size
    );
}
