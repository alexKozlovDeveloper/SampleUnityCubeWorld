using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Core.Helpers;

namespace Game.Core.CoreGameObjects
{
    public class Chunk
    {
        public List<List<List<Block>>> Content { get; private set; }

        public List<Block> ContentInRow
        {
            get
            {
                var result = new List<Block>();

                foreach (var square in Content)
                {
                    foreach (var list in square)
                    {
                        result.AddRange(list);
                    }
                }

                return result;
            }
        }

        public Chunk()
        {
            Content = ChunkHelper.GetEmptyChunkContent();
        }
    }
}
