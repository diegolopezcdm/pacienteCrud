using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServices.Persistencia;
using WebServices.Dominio;

namespace WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Pacientes" in code, svc and config file together.
    public class Pacientes : IPacientes
    {

        private PacienteDao pacienteDao = null;
        private PacienteDao PacienteDao
        {
            get
            {
                if (pacienteDao == null)
                    pacienteDao = new PacienteDao();
                return pacienteDao;
            }
        }


        public Dominio.Paciente crearPaciente(string nombre, string correo, int sede)
        {
            Paciente pacienteNuevo = new Paciente
            {
                Nombre = nombre
            };

            return PacienteDao.Crear(pacienteNuevo);
        }

        public Dominio.Paciente obtenerPaciente(int codigo)
        {
            return PacienteDao.Obtener(codigo);
        }

        public Dominio.Paciente ModificarPaciente(int codigo, string nombre, string correo, int sese)
        {
            Paciente pacienteNuevo = new Paciente
            {
                Codigo = codigo,
                Nombre = nombre
            };

            return PacienteDao.Modificar(pacienteNuevo);
        }

        public void EliminarPaciente(int codigo)
        {
            Paciente pacienteEliminar = PacienteDao.Obtener(codigo);
            PacienteDao.Eliminar(pacienteEliminar);
        }

        public List<Dominio.Paciente> ListarSesores()
        {
            return PacienteDao.ListarTodos().ToList();
        }
    }
}
