﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class Ventas : Presentacion.Metro_Template
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void LlenarTabla()
        {
            VentaNegocio neg = new VentaNegocio();
            try
            {
                dgvVentas.DataSource = neg.Listar();
                dgvVentas.Columns["IdVenta"].HeaderText = "ID";
                dgvVentas.Columns["FechaVenta"].HeaderText = "Fecha de Venta";
                dgvVentas.Columns["FechaRegistro"].Visible = false;
                dgvVentas.Columns["Activo"].Visible = false;
                dgvVentas.Update();
                dgvVentas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModVenta))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModVenta mod = new ModVenta();
                mod.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModVenta))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ProductoVendidoNegocio negPV = new ProductoVendidoNegocio();
                Venta v = (Venta)dgvVentas.CurrentRow.DataBoundItem;
                v.LstProductosVendidos = negPV.Listar(v.IdVenta);
                ModVenta detalles = new ModVenta(v);
                detalles.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DgvCompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModVenta))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModVenta detalles = new ModVenta((Venta)dgvVentas.CurrentRow.DataBoundItem);
                detalles.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
