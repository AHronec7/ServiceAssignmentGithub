using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InheritanceAssignment


{
    class FileType
    {
        //private string name;
        //private string type;
        //private int bytes;
        //private string contents;
        private FileInfo _fileinfo;
        private string filepath;


        public FileType()
        {
            filepath = "";
        }

        public FileType(string Fpath)
        {
            filepath = Fpath;
            _fileinfo = new FileInfo(Fpath);
        }
        public string Name
        {
            get { return (_fileinfo != null) ? _fileinfo.Name : ""; }
        }
        public string Filepath
        {
            get { return (_fileinfo != null) ? _fileinfo.DirectoryName : ""; }
        }
        public string Type
        {
            get { return (_fileinfo != null) ? _fileinfo.Extension : ""; }
        }
        public long Size
        {
            get { return (_fileinfo != null) ? _fileinfo.Length : 0; }
        }
        public DateTime Createddate
        {
            get { return (_fileinfo != null) ? _fileinfo.CreationTime : DateTime.MinValue; }
        }
        public bool Readonly
        {
            get { return (_fileinfo != null) ? _fileinfo.IsReadOnly : true;}                
        }
             
                       
        public bool Fileexist
        {
            get { return File.Exists(filepath); }
        }
        public string Location
        {
            set
            {
                filepath = value;
                if (File.Exists(value))
                {
                    _fileinfo = new FileInfo(value);                                    
                }

               
            }

            
            
            
        }
    }
}


    



