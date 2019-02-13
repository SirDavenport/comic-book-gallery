using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comics.Models
{
    public class ComicBook
    {
        public Artist[] Artists { get; set; }

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }

        public string DescriptionHtml { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        public bool Favorite { get; set; }
        public int Id { get; set; }
        public int IssueNumber { get; set; }
        public string SeriesTitle { get; set; }
    }
}
