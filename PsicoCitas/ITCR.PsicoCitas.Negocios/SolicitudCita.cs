using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITCR.PsicoCitas.Negocios
{
   public class SolicitudCita
    {
        //se declaran las variables del objeto solicitud de cita
        private int _idSolicitud; // esta es la nueva propiedad 
        private DateTime _fechaSolicitud;
        private String _motivoCita;
        private int _urgencia;
        private String _nombrePsicologo;
        private String _fechaPrevia;
        private int _confirmacion;
        private String _observacion;
        private int _idHorarioDisp;
        private String _diaSolicitud;
        private String _horaInicio;
        private String _horaFin;
        private String _nombreEstudiante;
        private String _carnetEstudiante;
        private String _carreraEstudiante;
        private String _correo;

        



        public SolicitudCita(DateTime fechaSolicitudP, String motivoCitaP, int urgenciaP, String nombrePsicologoP, String fechapreviaP,
          int confirmacionP, String observacionP, String diaP, String horaIniP, String horaFinP, String nomEstudianteP, String carnetEstudianteP)
        {


            this.FechaSolicitud = fechaSolicitudP;
            this.MotivoCita = motivoCitaP;
            this.Urgencia = urgenciaP;
            this.NombrePsicologo = nombrePsicologoP;
            this.FechaPrevia = fechapreviaP;
            this.Confirmacion = confirmacionP;
            this.Observacion = observacionP;
            this.DiaSolicitud = diaP;
            this.HoraInicio = horaIniP;
            this.HoraFin = horaFinP;
            this._nombreEstudiante = nomEstudianteP;
            this._carnetEstudiante = carnetEstudianteP;
          
        }





        public SolicitudCita(DateTime fechaSolicitudP, String motivoCitaP, int urgenciaP, String nombrePsicologoP, String fechapreviaP,
            int confirmacionP, String observacionP, String diaP, String horaIniP, String horaFinP, String nomEstudianteP, String carnetEstudianteP,String carreraP,String correoP) 
        {

            
            this.FechaSolicitud = fechaSolicitudP;
            this.MotivoCita = motivoCitaP;
            this.Urgencia = urgenciaP;
            this.NombrePsicologo = nombrePsicologoP;
            this.FechaPrevia = fechapreviaP;
            this.Confirmacion = confirmacionP;
            this.Observacion = observacionP;
            this.DiaSolicitud = diaP;
            this.HoraInicio = horaIniP;
            this.HoraFin = horaFinP;
            this._nombreEstudiante = nomEstudianteP;
            this._carnetEstudiante = carnetEstudianteP;
            this._carreraEstudiante = carreraP;
            this._correo = correoP;
        }

        #region gets y sets
        public DateTime FechaSolicitud
      {
          get { return _fechaSolicitud; }
          set { _fechaSolicitud = value; }
      }

        public String CarreraEstudiante
        {
            get { return _carreraEstudiante; }
            set { _carreraEstudiante = value; }
        }

        public String Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }


        public int IdSolicitud
      {
         get { return _idSolicitud; }
         set { _idSolicitud = value; }
      }

      public String MotivoCita
      {
          get { return _motivoCita; }
          set { _motivoCita = value; }
      }

      public int Urgencia
      {
          get { return _urgencia; }
          set { _urgencia = value; }
      }

      public String NombrePsicologo
      {
          get { return _nombrePsicologo; }
          set { _nombrePsicologo = value; }
      }

      public String FechaPrevia
      {
          get { return _fechaPrevia; }
          set { _fechaPrevia = value; }
      }

      public int Confirmacion
      {
          get { return _confirmacion; }
          set { _confirmacion = value; }
      }

      public String Observacion
      {
          get { return _observacion; }
          set { _observacion = value; }
      }

      public int IdHorarioDisp
      {
          get { return _idHorarioDisp; }
          set { _idHorarioDisp = value; }
      }

      public String DiaSolicitud
      {
          get { return _diaSolicitud; }
          set { _diaSolicitud = value; }
      }

      public String HoraInicio
      {
          get { return _horaInicio; }
          set { _horaInicio = value; }
      }

      public String HoraFin
      {
          get { return _horaFin; }
          set { _horaFin = value; }
      }

      public String NombreEstudiante
      {
          get { return _nombreEstudiante; }
          set { _nombreEstudiante = value; }
      }

      public String CarnetEstudiante
      {
          get { return _carnetEstudiante; }
          set { _carnetEstudiante = value; }
      }

        #endregion


      public void crearSolicitud(SolicitudCita CitaNueva) 
      {
          AccesoBase ab = new AccesoBase();
          int idHorario = ab.insertar_HorarioDisp(CitaNueva, 0);

          ab.insertar_Solicitud(CitaNueva, idHorario);

         
      }


    }
}
