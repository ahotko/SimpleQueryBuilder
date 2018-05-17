using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueryBuilder
{
    public partial class Builder
    {
        private Collection<Tuple<string, string, object>> _conditions = new Collection<Tuple<string, string, object>>();

        public Builder Where(string fieldName, object condition)
        {
            return Where(fieldName, "=", condition);
        }

        public Builder Where(string fieldName, string conditionType, object condition)
        {
            var _cond = new Tuple<string, string, object>(fieldName, conditionType, condition);
            _conditions.Add(_cond);
            return this;
        }
    }
}
