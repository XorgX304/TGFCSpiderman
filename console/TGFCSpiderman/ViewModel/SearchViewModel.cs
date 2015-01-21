﻿using System;

namespace taiyuanhitech.TGFCSpiderman.ViewModel
{
    class SearchViewModel
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool TopicOnly { get; set; }
        public string SortOrder { get; set; }
        public DateTime? ReplyEndDate { get; set; }
        public SearchViewModel Clone()
        {
            return (SearchViewModel)MemberwiseClone();
        }
    }
}
