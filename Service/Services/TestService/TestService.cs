﻿using Data.Context;
using Service.Interfaces.ITest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services.TestService
{
    public class TestService : ITest
    {
        public List<Model.ViewModel.TestViewModel> ObtenerTests()
        {
            var ret = new List<Model.ViewModel.TestViewModel>();
            using (var ctx = new Data.Context.ecommerceContext())
            {
                ret = ctx.Tests.Select(t => new Model.ViewModel.TestViewModel()
                {
                    Id = t.Id,
                    Prueba = t.Prueba
                }).ToList();
            }

            return ret;
        }
    }
}
