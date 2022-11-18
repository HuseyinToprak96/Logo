using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Business.DesignPatterns.ChainOfResponsibility
{
    public class ZipFileProcessHandler<T>:ProcessHandler
    {
        private string _uzanti;

        public ZipFileProcessHandler(string uzanti)
        {
            _uzanti = uzanti;
        }

        public override object Handle(object o)
        {
            var excelMemoryStream= o as MemoryStream;
            excelMemoryStream.Position = 0;
            using (var zipStream=new MemoryStream())
            {
                using (var archive=new ZipArchive(zipStream,ZipArchiveMode.Create,true))
                {
                    var zipFile = archive.CreateEntry($"{typeof(T).Name}.{_uzanti}");
                    using (var zipEntry=zipFile.Open())
                    {
                        excelMemoryStream.CopyTo(zipEntry);
                    }
                }
                return base.Handle(zipStream);
            }
           
        }
    }
}
