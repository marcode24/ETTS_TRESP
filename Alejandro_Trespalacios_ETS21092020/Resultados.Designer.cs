namespace Alejandro_Trespalacios_ETS21092020
{
    partial class Resultados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblTurismo = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno registrados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumnos por carrera:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(141, 37);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label3";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(71, 208);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(131, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Menu Principal";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(50, 128);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(81, 13);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Administracion: ";
            // 
            // lblTurismo
            // 
            this.lblTurismo.AutoSize = true;
            this.lblTurismo.Location = new System.Drawing.Point(50, 103);
            this.lblTurismo.Name = "lblTurismo";
            this.lblTurismo.Size = new System.Drawing.Size(50, 13);
            this.lblTurismo.TabIndex = 5;
            this.lblTurismo.Text = "Turismo: ";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(167, 128);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(35, 13);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "label3";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(167, 154);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(35, 13);
            this.lblC.TabIndex = 7;
            this.lblC.Text = "label3";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(167, 103);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(35, 13);
            this.lblT.TabIndex = 8;
            this.lblT.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Informatica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contaduria: ";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(167, 177);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(35, 13);
            this.lblI.TabIndex = 11;
            this.lblI.Text = "label3";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 263);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblTurismo);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblTurismo;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblI;
    }
}