using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

namespace Patterns_03
{
    /// <summary>
    /// Динамический класс тестовый вариант
    /// </summary>
    class ElastoClass : DynamicObject
    {
        private Dictionary<string, object> members = new Dictionary<string, object>();

        /// <summary>
        /// Попытка установки значения
        /// </summary>
        /// <param name="binder">свойство</param>
        /// <param name="value">значение</param>
        /// <returns>состояние</returns>
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (value != null)
                members[binder.Name] = value;
            else if (members.ContainsKey(binder.Name))
                members.Remove(binder.Name);
            return true;
        }

        /// <summary>
        /// Попытка получения значения
        /// </summary>
        /// <param name="binder">свойство</param>
        /// <param name="result">результат</param>
        /// <returns>состояние</returns>
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (members.ContainsKey(binder.Name))
            {
                result = members[binder.Name];
                return true;
            }
            return base.TryGetMember(binder, out result);
        }

        /// <summary>
        /// Попытка вызова метода
        /// </summary>
        /// <param name="binder">метод</param>
        /// <param name="args">аргументы</param>
        /// <param name="result">результат</param>
        /// <returns>состояние</returns>
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            if (members.ContainsKey(binder.Name))
            {
                Delegate d = members[binder.Name] as Delegate;
                if (d != null)
                {
                    result = d.DynamicInvoke(args);
                    return true;
                }
            }
            return base.TryInvokeMember(binder, args, out result);
        }
    }
}
