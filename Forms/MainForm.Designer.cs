namespace MyWinFormsApp.Forms;

partial class MainForm
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
        this.addressControl1 = new MyWinFormsApp.UserControls.AddressControl();
        this.lblResult = new System.Windows.Forms.Label();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // addressControl1
        // 
        this.addressControl1.Location = new System.Drawing.Point(20, 20);
        this.addressControl1.Name = "addressControl1";
        this.addressControl1.Size = new System.Drawing.Size(330, 260);
        this.addressControl1.TabIndex = 0;
        // 
        // lblResult
        // 
        this.lblResult.AutoSize = true;
        this.lblResult.Location = new System.Drawing.Point(20, 300);
        this.lblResult.Name = "lblResult";
        this.lblResult.Size = new System.Drawing.Size(57, 15);
        this.lblResult.TabIndex = 1;
        this.lblResult.Text = "Kết quả:";
        // 
        // txtResult
        // 
        this.txtResult.Location = new System.Drawing.Point(20, 318);
        this.txtResult.Multiline = true;
        this.txtResult.Name = "txtResult";
        this.txtResult.ReadOnly = true;
        this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtResult.Size = new System.Drawing.Size(330, 60);
        this.txtResult.TabIndex = 2;
        // 
        // btnSave
        // 
        this.btnSave.Location = new System.Drawing.Point(20, 395);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(100, 30);
        this.btnSave.TabIndex = 3;
        this.btnSave.Text = "Lưu";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(380, 450);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.txtResult);
        this.Controls.Add(this.lblResult);
        this.Controls.Add(this.addressControl1);
        this.Name = "MainForm";
        this.Text = "Quản lý Địa chỉ";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private MyWinFormsApp.UserControls.AddressControl addressControl1;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.Button btnSave;
}