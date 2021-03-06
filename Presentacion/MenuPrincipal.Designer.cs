﻿namespace Presentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnVentas = new MetroFramework.Controls.MetroButton();
            this.BtnCompras = new MetroFramework.Controls.MetroButton();
            this.BtnEmpleados = new MetroFramework.Controls.MetroButton();
            this.BtnMarcas = new MetroFramework.Controls.MetroButton();
            this.BtnTiposProducto = new MetroFramework.Controls.MetroButton();
            this.BtnProveedores = new MetroFramework.Controls.MetroButton();
            this.BtnClientes = new MetroFramework.Controls.MetroButton();
            this.BtnProductos = new MetroFramework.Controls.MetroButton();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            this.BtnLogout = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnVentas
            // 
            this.BtnVentas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVentas.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnVentas.Location = new System.Drawing.Point(51, 74);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(200, 120);
            this.BtnVentas.TabIndex = 0;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVentas.UseSelectable = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnCompras
            // 
            this.BtnCompras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCompras.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnCompras.Location = new System.Drawing.Point(299, 74);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Size = new System.Drawing.Size(200, 120);
            this.BtnCompras.TabIndex = 1;
            this.BtnCompras.Text = "Compras";
            this.BtnCompras.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnCompras.UseSelectable = true;
            this.BtnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEmpleados.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnEmpleados.Location = new System.Drawing.Point(51, 225);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(120, 120);
            this.BtnEmpleados.TabIndex = 2;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEmpleados.UseSelectable = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnMarcas
            // 
            this.BtnMarcas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMarcas.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnMarcas.Location = new System.Drawing.Point(215, 376);
            this.BtnMarcas.Name = "BtnMarcas";
            this.BtnMarcas.Size = new System.Drawing.Size(120, 120);
            this.BtnMarcas.TabIndex = 6;
            this.BtnMarcas.Text = "Marcas";
            this.BtnMarcas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMarcas.UseSelectable = true;
            this.BtnMarcas.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // BtnTiposProducto
            // 
            this.BtnTiposProducto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnTiposProducto.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnTiposProducto.Location = new System.Drawing.Point(379, 376);
            this.BtnTiposProducto.Name = "BtnTiposProducto";
            this.BtnTiposProducto.Size = new System.Drawing.Size(120, 120);
            this.BtnTiposProducto.TabIndex = 7;
            this.BtnTiposProducto.Text = "Tipos\r\nde\r\nProducto";
            this.BtnTiposProducto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnTiposProducto.UseSelectable = true;
            this.BtnTiposProducto.Click += new System.EventHandler(this.BtnTiposProducto_Click);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnProveedores.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnProveedores.Location = new System.Drawing.Point(379, 225);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(120, 120);
            this.BtnProveedores.TabIndex = 4;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnProveedores.UseSelectable = true;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnClientes.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnClientes.Location = new System.Drawing.Point(215, 225);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(120, 120);
            this.BtnClientes.TabIndex = 3;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnClientes.UseSelectable = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnProductos.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnProductos.Location = new System.Drawing.Point(51, 376);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(120, 120);
            this.BtnProductos.TabIndex = 5;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnProductos.UseSelectable = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnSalir.Location = new System.Drawing.Point(51, 520);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(200, 25);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnSalir.UseSelectable = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnLogout.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnLogout.Location = new System.Drawing.Point(299, 520);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(200, 25);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.Text = "Cerrar Sesión";
            this.BtnLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnLogout.UseSelectable = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 566);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnProductos);
            this.Controls.Add(this.BtnProveedores);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnTiposProducto);
            this.Controls.Add(this.BtnMarcas);
            this.Controls.Add(this.BtnEmpleados);
            this.Controls.Add(this.BtnCompras);
            this.Controls.Add(this.BtnVentas);
            this.MaximumSize = new System.Drawing.Size(550, 566);
            this.MinimumSize = new System.Drawing.Size(550, 566);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnVentas;
        private MetroFramework.Controls.MetroButton BtnCompras;
        private MetroFramework.Controls.MetroButton BtnEmpleados;
        private MetroFramework.Controls.MetroButton BtnMarcas;
        private MetroFramework.Controls.MetroButton BtnTiposProducto;
        private MetroFramework.Controls.MetroButton BtnProveedores;
        private MetroFramework.Controls.MetroButton BtnClientes;
        private MetroFramework.Controls.MetroButton BtnProductos;
        private MetroFramework.Controls.MetroButton BtnSalir;
        private MetroFramework.Controls.MetroButton BtnLogout;
    }
}