using System.Collections.Generic;

namespace DmgPropertyService.Domain
{

    /*
     * To return pages results from my repositories I defined
     * class called PagedResult<T> in my core library. PagedResult<T> 
     * defines all important properties we need when dealing with paged results. 
     *  Results property contains objects in current page and the 
     *  other properties give informations about result set.
     *  RowCount tells how much rows there was without paging.
     *  Although it is possible to give better names to properties we are happy with current names right now. 
     */
    public class PagedResult<T>
    {

        public IList<T> Results { get; set; }

        public int CurrentPage { get; set; }

        public int PageCount { get; set; }

        public int PageSize { get; set; }

        public int RowCount { get; set; }

    }
}
