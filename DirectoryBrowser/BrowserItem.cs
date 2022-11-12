using System;

namespace DirectoryBrowser
{
    public class BrowserItem
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public BrowserItemType Type { get; set; }
        public DateTime Date { get; set; }
        public string Path { get; set; }
    }
}