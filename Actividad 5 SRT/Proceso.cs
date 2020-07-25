using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5_SRT
{
    class Proceso
    {
        int ID;
        int Tiempo;
        int TiempoTranscurrido;
        int TiempoLlegada;
        int TiempoRespuesta;
        int TiempoFinalizacion;
        int TiempoRestante;
        bool Respuesta = false;

        public Proceso(int ID, int Tiempo)
        {
            this.ID = ID;
            this.Tiempo = Tiempo;
            this.TiempoTranscurrido = 0;
            this.TiempoRestante = Tiempo;
        }

        public int GetID()
        {
            return ID;
        }

        public int GetTiempo()
        {
            return Tiempo;
        }
        public int GetTiempoRestante()
        {
            return TiempoRestante;
        }
        public void SetTiempoRestante(int TR)
        {
            TiempoRestante = TR;
        }
        public int GetTiempoTranscurrido()
        {
            return TiempoTranscurrido;
        }
        public void SetTiempoTranscurrido(int TT)
        {
            TiempoTranscurrido=TT;
        }
        public int GetTiempoLlegada()
        {
            return TiempoLlegada;
        }

        public void SetTiempoLlegada(int Numero)
        {
            TiempoLlegada = Numero;
        }
        public int GetTiempoRespuesta()
        {
            return TiempoRespuesta;
        }

        public void SetTiempoRespuesta(int Numero)
        {
            TiempoRespuesta = Numero;
        }

        public void SetRespuesta(bool Booleano)
        {
            Respuesta = Booleano;
        }

        public bool GetRespuesta()
        {
            return Respuesta;
        }
        public int GetTiempoFinalizacion()
        {
            return TiempoFinalizacion;
        }

        public void SetTiempoFinalizacion(int Numero)
        {
            TiempoFinalizacion = Numero;
        }
    }
}
