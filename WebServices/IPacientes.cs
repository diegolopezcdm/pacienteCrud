using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServices.Dominio;

namespace WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPacientes" in both code and config file together.
    [ServiceContract]
    public interface IPacientes
    {
        [OperationContract]
        Paciente crearPaciente(string nombre, string correo, int sede);
        [OperationContract]
        Paciente obtenerPaciente(int codigo);
        [OperationContract]
        Paciente ModificarPaciente(int codigo, string nombre, string correo, int sese);
        [OperationContract]
        void EliminarPaciente(int codigo);
        [OperationContract]
        List<Paciente> ListarSesores();
    }
}
