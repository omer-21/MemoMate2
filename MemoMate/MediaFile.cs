using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace NoteTaker
{
    public class MediaFile
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public WMPPlayState playState { get; }
    }
}
