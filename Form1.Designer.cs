
namespace charging_point_digital_twin
{
    partial class Form1
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
            this.main_tab = new System.Windows.Forms.TabControl();
            this.IEC61850_nodes_tab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SIMULINK_script_tab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OCPP_script_tab = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.main_tab.SuspendLayout();
            this.IEC61850_nodes_tab.SuspendLayout();
            this.SIMULINK_script_tab.SuspendLayout();
            this.OCPP_script_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tab
            // 
            this.main_tab.Controls.Add(this.IEC61850_nodes_tab);
            this.main_tab.Controls.Add(this.SIMULINK_script_tab);
            this.main_tab.Controls.Add(this.OCPP_script_tab);
            this.main_tab.Location = new System.Drawing.Point(5, 0);
            this.main_tab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.main_tab.Name = "main_tab";
            this.main_tab.SelectedIndex = 0;
            this.main_tab.Size = new System.Drawing.Size(955, 292);
            this.main_tab.TabIndex = 0;
            // 
            // IEC61850_nodes_tab
            // 
            this.IEC61850_nodes_tab.Controls.Add(this.button1);
            this.IEC61850_nodes_tab.Controls.Add(this.treeView1);
            this.IEC61850_nodes_tab.Location = new System.Drawing.Point(4, 22);
            this.IEC61850_nodes_tab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IEC61850_nodes_tab.Name = "IEC61850_nodes_tab";
            this.IEC61850_nodes_tab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IEC61850_nodes_tab.Size = new System.Drawing.Size(947, 266);
            this.IEC61850_nodes_tab.TabIndex = 0;
            this.IEC61850_nodes_tab.Text = "IEC61850_nodes";
            this.IEC61850_nodes_tab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(940, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload a new SCD file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(5, 4);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(941, 237);
            this.treeView1.TabIndex = 0;
            // 
            // SIMULINK_script_tab
            // 
            this.SIMULINK_script_tab.Controls.Add(this.button2);
            this.SIMULINK_script_tab.Controls.Add(this.richTextBox1);
            this.SIMULINK_script_tab.Location = new System.Drawing.Point(4, 22);
            this.SIMULINK_script_tab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SIMULINK_script_tab.Name = "SIMULINK_script_tab";
            this.SIMULINK_script_tab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SIMULINK_script_tab.Size = new System.Drawing.Size(947, 266);
            this.SIMULINK_script_tab.TabIndex = 1;
            this.SIMULINK_script_tab.Text = "SIMULINK script";
            this.SIMULINK_script_tab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 243);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(940, 25);
            this.button2.TabIndex = 0;
            this.button2.Text = "Save MATLAB script";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 5);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(945, 234);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // OCPP_script_tab
            // 
            this.OCPP_script_tab.Controls.Add(this.button3);
            this.OCPP_script_tab.Controls.Add(this.label2);
            this.OCPP_script_tab.Controls.Add(this.label1);
            this.OCPP_script_tab.Controls.Add(this.richTextBox3);
            this.OCPP_script_tab.Controls.Add(this.richTextBox2);
            this.OCPP_script_tab.Location = new System.Drawing.Point(4, 22);
            this.OCPP_script_tab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OCPP_script_tab.Name = "OCPP_script_tab";
            this.OCPP_script_tab.Size = new System.Drawing.Size(947, 266);
            this.OCPP_script_tab.TabIndex = 2;
            this.OCPP_script_tab.Text = "OCPP script";
            this.OCPP_script_tab.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 15);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(465, 230);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(475, 15);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(465, 230);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OCPP Central Management Station (CMS) script ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OCPP Charging Point (CP) script ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(940, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save OCPP script";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 292);
            this.Controls.Add(this.main_tab);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.main_tab.ResumeLayout(false);
            this.IEC61850_nodes_tab.ResumeLayout(false);
            this.SIMULINK_script_tab.ResumeLayout(false);
            this.OCPP_script_tab.ResumeLayout(false);
            this.OCPP_script_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl main_tab;
        private System.Windows.Forms.TabPage IEC61850_nodes_tab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage SIMULINK_script_tab;
        private System.Windows.Forms.TabPage OCPP_script_tab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

