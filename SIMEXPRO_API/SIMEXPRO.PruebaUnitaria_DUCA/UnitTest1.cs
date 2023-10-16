using Moq;
using SIMEXPRO.API.Controllers.ControllersAduanas;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.DataAccess.Repositories.Adua;
using SIMEXPRO.Entities.Entities;
using System;
using Xunit;

namespace SIMEXPRO.PruebaUnitaria_DUCA
{
    public class UnitTest1 : IClassFixture<DucaRepository>
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
        //        duca_No_Duca = "230011011994J",
        //        duca_No_Correlativo_Referencia = "AHMZ220125288H",
        //        duca_AduanaRegistro = 1,
        //        duca_AduanaDestino = 2,
        //        duca_Regimen_Aduanero = 1,
        //        duca_Modalidad = "N/A",
        //        duca_Clase = "N/A",
        //        duca_FechaVencimiento = new DateTime(),
        //        duca_Pais_Procedencia = 3,
        //        duca_Pais_Destino = 97,
        //        duca_Deposito_Aduanero = "N/A",
        //        duca_Lugar_Desembarque = 25110,
        //        duca_Manifiesto = "AHMZ220125288H",
        //        duca_Titulo = "0011HN20220110",
        //        trli_Id = 3,
        //        usua_UsuarioModificacion = 1,
        //        duca_FechaModificacion = new DateTime()
        //    };

        //    _ducaController.EditarPart1(datos);

        //}

        DucaRepository _ducaRepository = new();

        [Fact]
        public void Test1()
        {
            tbDuca datos = new()
            {
                duca_Id = 1,
                duca_No_Duca = "230011011994J",
                duca_No_Correlativo_Referencia = "AHMZ220125288H",
                duca_AduanaRegistro = 1,
                duca_AduanaDestino = 2,
                duca_Regimen_Aduanero = 1,
                duca_Modalidad = "---",
                duca_Clase = "---",
                duca_FechaVencimiento = new DateTime(),
                duca_Pais_Procedencia = 3,
                duca_Pais_Destino = 97,
                duca_Deposito_Aduanero = "---",
                duca_Lugar_Desembarque = 25110,
                duca_Manifiesto = "AHMZ220125288H",
                duca_Titulo = "0011HN20220110",
                trli_Id = 3,
                usua_UsuarioModificacion = 1,
                duca_FechaModificacion = new DateTime()
            };

            _ducaRepository.Update(datos);

        }
    }
}
