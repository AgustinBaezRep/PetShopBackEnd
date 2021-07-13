using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces.ITest
{
    public interface ITest
    {
        List<Model.ViewModel.TestViewModel> ObtenerTests();
    }
}
