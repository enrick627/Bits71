namespace Bits
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_lijstopvragen = new System.Windows.Forms.Button();
            this.textBox_zoeknaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.textBox_naamverwijder = new System.Windows.Forms.TextBox();
            this.label_toevoeg = new System.Windows.Forms.Label();
            this.textBox_toevoegen = new System.Windows.Forms.TextBox();
            this.label_bewerken = new System.Windows.Forms.Label();
            this.textBox_bewerken = new System.Windows.Forms.TextBox();
            this.button_toevoeg = new System.Windows.Forms.Button();
            this.button1_verwijder = new System.Windows.Forms.Button();
            this.button_zoek = new System.Windows.Forms.Button();
            this.button_bewerken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(26, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(762, 196);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_lijstopvragen
            // 
            this.button_lijstopvragen.Location = new System.Drawing.Point(26, 52);
            this.button_lijstopvragen.Name = "button_lijstopvragen";
            this.button_lijstopvragen.Size = new System.Drawing.Size(75, 23);
            this.button_lijstopvragen.TabIndex = 1;
            this.button_lijstopvragen.Text = "Lijst";
            this.button_lijstopvragen.UseVisualStyleBackColor = true;
            this.button_lijstopvragen.Click += new System.EventHandler(this.button_lijstopvragen_Click);
            // 
            // textBox_zoeknaam
            // 
            this.textBox_zoeknaam.Location = new System.Drawing.Point(157, 109);
            this.textBox_zoeknaam.Name = "textBox_zoeknaam";
            this.textBox_zoeknaam.Size = new System.Drawing.Size(100, 22);
            this.textBox_zoeknaam.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "zoek naam";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 144);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(105, 17);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Naam verwijder";
            // 
            // textBox_naamverwijder
            // 
            this.textBox_naamverwijder.Location = new System.Drawing.Point(157, 144);
            this.textBox_naamverwijder.Name = "textBox_naamverwijder";
            this.textBox_naamverwijder.Size = new System.Drawing.Size(100, 22);
            this.textBox_naamverwijder.TabIndex = 9;
            // 
            // label_toevoeg
            // 
            this.label_toevoeg.AutoSize = true;
            this.label_toevoeg.Location = new System.Drawing.Point(16, 177);
            this.label_toevoeg.Name = "label_toevoeg";
            this.label_toevoeg.Size = new System.Drawing.Size(75, 17);
            this.label_toevoeg.TabIndex = 10;
            this.label_toevoeg.Text = "toevoegen";
            // 
            // textBox_toevoegen
            // 
            this.textBox_toevoegen.Location = new System.Drawing.Point(157, 177);
            this.textBox_toevoegen.Name = "textBox_toevoegen";
            this.textBox_toevoegen.Size = new System.Drawing.Size(100, 22);
            this.textBox_toevoegen.TabIndex = 11;
            this.textBox_toevoegen.TextChanged += new System.EventHandler(this.textBox_toevoegen_TextChanged);
            // 
            // label_bewerken
            // 
            this.label_bewerken.AutoSize = true;
            this.label_bewerken.Location = new System.Drawing.Point(402, 110);
            this.label_bewerken.Name = "label_bewerken";
            this.label_bewerken.Size = new System.Drawing.Size(70, 17);
            this.label_bewerken.TabIndex = 12;
            this.label_bewerken.Text = "Bewerken";
            // 
            // textBox_bewerken
            // 
            this.textBox_bewerken.Location = new System.Drawing.Point(505, 108);
            this.textBox_bewerken.Name = "textBox_bewerken";
            this.textBox_bewerken.Size = new System.Drawing.Size(100, 22);
            this.textBox_bewerken.TabIndex = 13;
            // 
            // button_toevoeg
            // 
            this.button_toevoeg.Location = new System.Drawing.Point(289, 175);
            this.button_toevoeg.Name = "button_toevoeg";
            this.button_toevoeg.Size = new System.Drawing.Size(75, 23);
            this.button_toevoeg.TabIndex = 14;
            this.button_toevoeg.Text = "voeg toe";
            this.button_toevoeg.UseVisualStyleBackColor = true;
            this.button_toevoeg.Click += new System.EventHandler(this.button_toevoeg_Click);
            // 
            // button1_verwijder
            // 
            this.button1_verwijder.Location = new System.Drawing.Point(289, 144);
            this.button1_verwijder.Name = "button1_verwijder";
            this.button1_verwijder.Size = new System.Drawing.Size(75, 23);
            this.button1_verwijder.TabIndex = 15;
            this.button1_verwijder.Text = "Verwijder";
            this.button1_verwijder.UseVisualStyleBackColor = true;
            // 
            // button_zoek
            // 
            this.button_zoek.Location = new System.Drawing.Point(289, 107);
            this.button_zoek.Name = "button_zoek";
            this.button_zoek.Size = new System.Drawing.Size(75, 23);
            this.button_zoek.TabIndex = 16;
            this.button_zoek.Text = "zoek";
            this.button_zoek.UseVisualStyleBackColor = true;
            // 
            // button_bewerken
            // 
            this.button_bewerken.Location = new System.Drawing.Point(658, 109);
            this.button_bewerken.Name = "button_bewerken";
            this.button_bewerken.Size = new System.Drawing.Size(90, 23);
            this.button_bewerken.TabIndex = 17;
            this.button_bewerken.Text = "Bewerken";
            this.button_bewerken.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_bewerken);
            this.Controls.Add(this.button_zoek);
            this.Controls.Add(this.button1_verwijder);
            this.Controls.Add(this.button_toevoeg);
            this.Controls.Add(this.textBox_bewerken);
            this.Controls.Add(this.label_bewerken);
            this.Controls.Add(this.textBox_toevoegen);
            this.Controls.Add(this.label_toevoeg);
            this.Controls.Add(this.textBox_naamverwijder);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_zoeknaam);
            this.Controls.Add(this.button_lijstopvragen);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_lijstopvragen;
        private System.Windows.Forms.TextBox textBox_zoeknaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox textBox_naamverwijder;
        private System.Windows.Forms.Label label_toevoeg;
        private System.Windows.Forms.TextBox textBox_toevoegen;
        private System.Windows.Forms.Label label_bewerken;
        private System.Windows.Forms.TextBox textBox_bewerken;
        private System.Windows.Forms.Button button_toevoeg;
        private System.Windows.Forms.Button button1_verwijder;
        private System.Windows.Forms.Button button_zoek;
        private System.Windows.Forms.Button button_bewerken;
    }
}

