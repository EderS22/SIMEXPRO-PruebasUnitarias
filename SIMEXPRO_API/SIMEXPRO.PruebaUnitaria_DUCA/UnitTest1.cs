using Microsoft.AspNetCore.Mvc;
using Moq;
using SIMEXPRO.API.Controllers.ControllersAduanas;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.BussinessLogic;
using SIMEXPRO.DataAccess;
using SIMEXPRO.DataAccess.Repositories.Adua;
using SIMEXPRO.Entities.Entities;
using System;
using Xunit;

namespace SIMEXPRO.PruebaUnitaria_DUCA
{
    public class UnitTest1
    {
        //private readonly DucaController _ducaController;

        //public UnitTest1(DucaController ducaController)
        //{
        //    _ducaController = ducaController;
        //}

        //[Fact]
        //public void Test1()
        //{
        //    DucaViewModel datos = new()
        //    {
        //        duca_Id = 1,
        //        duca_No_Duca = "230011011994H",
        //        duca_No_Correlativo_Referencia = "AHMZ220125288H",
        //        duca_AduanaRegistro = 1,
        //        duca_AduanaDestino = 2,
        //        duca_Regimen_Aduanero = 1,
        //        duca_Modalidad = "N/A",
        //        duca_Clase = "N/A",
        //        duca_FechaVencimiento = new DateTime(2023, 10, 16, 01, 15, 00),
        //        duca_Pais_Procedencia = 3,
        //        duca_Pais_Destino = 97,
        //        duca_Deposito_Aduanero = "N/A",
        //        duca_Lugar_Desembarque = 25110,
        //        duca_Manifiesto = "AHMZ220125288H",
        //        duca_Titulo = "0011HN20220110",
        //        trli_Id = 3,
        //        usua_UsuarioModificacion = 1,
        //        duca_FechaModificacion = new DateTime(2023, 10, 16, 01, 15, 00)
        //    };

        //    IActionResult result = _ducaController.EditarPart1(datos);
        //}

        DucaRepository _ducaRepository = new();

        [Fact]
        public void Test1()
        {
            tbDuca datos = new()
            {
                duca_Id = 1,
                duca_No_Duca = "HVASUV2187T",
                duca_No_Correlativo_Referencia = "AHMZ220125288H",
                duca_AduanaRegistro = 1,
                duca_AduanaDestino = 2,
                duca_Regimen_Aduanero = 1,
                duca_Modalidad = "N/A",
                duca_Clase = "N/A",
                duca_FechaVencimiento = new DateTime(2023, 10, 16, 01, 15, 00),
                duca_Pais_Procedencia = 3,
                duca_Pais_Destino = 97,
                duca_Deposito_Aduanero = "N/A",
                duca_Lugar_Desembarque = 25110,
                duca_Manifiesto = "AHMZ220125288H",
                duca_Titulo = "0011HN20220110",
                trli_Id = 3,
                usua_UsuarioModificacion = 1,
                duca_FechaModificacion = new DateTime(2023, 10, 16, 01, 15, 00)
            };

            RequestStatus result = _ducaRepository.Update(datos);

            Assert.Equal(1, result.CodeStatus);
        }
    }
}
