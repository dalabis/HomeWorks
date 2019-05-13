using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    interface IStackString
    {
        /// <summary>
        /// абстрактный метод проверки стека на пустоту
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// абстрактный метод получения элемента с вершины стека
        /// </summary>
        /// <returns></returns>
        string Get();

        /// <summary>
        /// абстрактный метод добавления элемента на вершину стека
        /// </summary>
        /// <param name="value"></param>
        void Set(string value);

    }
}