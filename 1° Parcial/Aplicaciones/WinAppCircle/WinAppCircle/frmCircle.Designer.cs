namespace WinAppCircle
{
    partial class frmCircle
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.grbOutPuts = new System.Windows.Forms.GroupBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.grbArea = new System.Windows.Forms.Label();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutPuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtRadius);
            this.grbInputs.Controls.Add(this.lblRadius);
            this.grbInputs.Location = new System.Drawing.Point(30, 28);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(375, 100);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(30, 134);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(375, 100);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            // 
            // grbOutPuts
            // 
            this.grbOutPuts.Controls.Add(this.grbArea);
            this.grbOutPuts.Controls.Add(this.txtArea);
            this.grbOutPuts.Controls.Add(this.lblArea);
            this.grbOutPuts.Controls.Add(this.txtPerimeter);
            this.grbOutPuts.Controls.Add(this.lblPerimeter);
            this.grbOutPuts.Location = new System.Drawing.Point(30, 240);
            this.grbOutPuts.Name = "grbOutPuts";
            this.grbOutPuts.Size = new System.Drawing.Size(375, 100);
            this.grbOutPuts.TabIndex = 2;
            this.grbOutPuts.TabStop = false;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(23, 35);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(82, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Ingrese el radio:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(111, 32);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(111, 19);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
            this.txtPerimeter.TabIndex = 5;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(23, 22);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(54, 13);
            this.lblPerimeter.TabIndex = 4;
            this.lblPerimeter.Text = "Perimetro:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(26, 41);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(150, 41);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(262, 41);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(111, 62);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 7;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(23, 65);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(10, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = " ";
            // 
            // grbArea
            // 
            this.grbArea.AutoSize = true;
            this.grbArea.Location = new System.Drawing.Point(23, 65);
            this.grbArea.Name = "grbArea";
            this.grbArea.Size = new System.Drawing.Size(32, 13);
            this.grbArea.TabIndex = 8;
            this.grbArea.Text = "Area:";
            // 
            // frmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 395);
            this.Controls.Add(this.grbOutPuts);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmCircle";
            this.Text = "Circulo";
            this.Load += new System.EventHandler(this.frmCircle_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutPuts.ResumeLayout(false);
            this.grbOutPuts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutPuts;
        private System.Windows.Forms.Label grbArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblPerimeter;
    }
}

