namespace bulutbilisim;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(160, 72);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(163, 39);
        label1.TabIndex = 0;
        label1.Text = "İlk Oluşturulmuş Label";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(160, 111);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(122, 15);
        label2.TabIndex = 1;
        label2.Text = "rüzgarın eklediği label";
        label2.Click += label2_Click;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(158, 186);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(114, 34);
        button1.TabIndex = 2;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(914, 600);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    #endregion

    private Label label2;
}