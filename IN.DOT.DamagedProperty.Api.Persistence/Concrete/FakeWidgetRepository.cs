﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IN.DOT.DamagedProperty.Api.Domain.Model;
using IN.DOT.DamagedProperty.Api.Persistence.Abstract;
﻿using IN.DOT.DamagedProperty.Api.Persistence.Interface;

namespace IN.DOT.DamagedProperty.Api.Persistence.Concrete
{
    public class FakeWidgetRepository : IRepository<Widget>
    {
        private readonly IList<Widget> _widgetList;

        public FakeWidgetRepository()
        {
            _widgetList = new List<Widget>();
            _widgetList.Add(new Widget()
            {
                Id = 1,
                Name = "Widget1"
            });
            _widgetList.Add(new Widget()
            {
                Id = 2,
                Name = "Widget2"
            });
        }



        #region " Methods "

        public Widget Create(Widget entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Widget> Get()
        {
            return _widgetList;
        }

        public IList<Widget> Get(Func<Widget, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Widget Update(int id, Widget entity)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}