//Copyright SimBlocks LLC 2016-2022
//https://www.simblocks.io/
//The source code in this file is licensed under the MIT License. See the LICENSE text file for full terms.
using System.Collections.Generic;
using System.Linq;
using sbio.owsdk.Geodetic;

namespace sbio.owsdk.Features
{
  public sealed class FeatureWay : Feature
  {
    public Geodetic2d[] Coordinates
    {
      get { return m_Coordinates; }
    }

    public FeatureWay(ulong id, IEnumerable<FeatureTag> tags, IEnumerable<Geodetic2d> coordinates)
      : this(id, tags.ToArray(), coordinates.ToArray())
    {
    }

    public FeatureWay(ulong id, FeatureTag[] tags, IEnumerable<Geodetic2d> coordinates)
      : this(id, tags, coordinates.ToArray())
    {
    }

    public FeatureWay(ulong id, IEnumerable<FeatureTag> tags, Geodetic2d[] coordinates)
      : this(id, tags.ToArray(), coordinates)
    {
    }

    public FeatureWay(ulong id, FeatureTag[] tags, Geodetic2d[] coordinates)
      : base(id, tags)
    {
      m_Coordinates = coordinates;
    }

    private readonly Geodetic2d[] m_Coordinates;
  }
}


//Copyright SimBlocks LLC 2016-2022
//https://www.simblocks.io/
//The source code in this file is licensed under the MIT License. See the LICENSE text file for full terms.
