﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class ModContacto : MetroFramework.Forms.MetroForm
    {
        private bool[] EntradasVal = new bool[4];
        Validaciones val = new Validaciones();
        Contacto c = null;
        int IdRelacion;

        public ModContacto(int id)
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            c = new Contacto();
            IdRelacion = id;
        }

        public ModContacto(Contacto C)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtNombre.Text = C.Nombre;
            TxtApellido.Text = C.Apellido;
            TxtDni.Text = C.Dni.ToString();
            TxtEmail.Text = C.Email;
            c = C;
        }

        private void ModContacto_Load(object sender, EventArgs e)
        {
            bool b;
            if (c.IdContacto != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
            }
            ValidarEntradas();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            TxtNombre.Text = TxtNombre.Text.TrimStart();
            ValidarTxt(0, val.EsAlfa, TxtNombre, tileNombre, lblNombre);
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            TxtApellido.Text = TxtApellido.Text.TrimStart();
            ValidarTxt(1, val.EsAlfa, TxtApellido, tileApellido, lblApellido);
        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {
            TxtDni.Text = TxtDni.Text.TrimStart();
            ValidarTxt(2, val.EsDni, TxtDni, tileDni, lblDni);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            TxtEmail.Text = TxtEmail.Text.TrimStart();
            ValidarTxt(3, val.EsEmail, TxtEmail, tileEmail, lblEmail);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            ContactoNegocio neg = new ContactoNegocio();
            try
            {
                c.Nombre = TxtNombre.Text.Trim();
                c.Apellido = TxtApellido.Text.Trim();
                c.Dni = Convert.ToInt32(TxtDni.Text.Trim());
                c.Email = TxtEmail.Text.Trim();
                if (c.IdContacto != 0)
                {
                    neg.Modificar(c);
                }
                else
                {
                    c.IdContacto = Convert.ToInt32(neg.Agregar(c));
                    neg.Registrar(c.IdContacto, IdRelacion);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void ValidarTxt(int c, Func<string, bool> metodo, MetroFramework.Controls.MetroTextBox txt, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            if (metodo(txt.Text))
            {
                EntradasVal[c] = true;
                val.CambiarColor(t, l, 'g');
            }
            else
            {
                EntradasVal[c] = false;
                if (txt.Text == "")
                {
                    val.CambiarColor(t, l, 'b');
                }
                else
                {
                    val.CambiarColor(t, l, 'r');
                }
            }
            ValidarEntradas();
        }

        private void LimpiarEntradas()
        {
            val.CambiarColor(tileNombre, lblNombre, 'b');
            val.CambiarColor(tileApellido, lblApellido, 'b');
            val.CambiarColor(tileDni, lblDni, 'b');
            val.CambiarColor(tileEmail, lblEmail, 'b');
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDni.Text = "";
            TxtEmail.Text = "";
        }

        private void ValidarEntradas()
        {
            int i;
            bool v = true;
            for (i = 0; i < EntradasVal.Length; i++)
            {
                if (EntradasVal[i] == false)
                {
                    v = false;
                    break;
                }
            }
            if (v == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }

        private void ModContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool v = true;
            for (int i = 0; i < EntradasVal.Length - 1; i++)
            {
                if (EntradasVal[i] == false)
                {
                    v = false;
                    break;
                }
            }
            if (e.KeyChar == 13 && v == true)
            {
                BtnMod_Click(sender, e);
            }
        }
    }
}
