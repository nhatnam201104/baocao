namespace MyWinFormsApp.UserControls;

partial class AddressControl
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.lblSoNha = new System.Windows.Forms.Label();
        this.txtSoNha = new System.Windows.Forms.TextBox();
        this.lblDuong = new System.Windows.Forms.Label();
        this.txtDuong = new System.Windows.Forms.TextBox();
        this.lblPhuong = new System.Windows.Forms.Label();
        this.txtPhuong = new System.Windows.Forms.TextBox();
        this.lblQuan = new System.Windows.Forms.Label();
        this.txtQuan = new System.Windows.Forms.TextBox();
        this.lblThanhPho = new System.Windows.Forms.Label();
        this.txtThanhPho = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lblSoNha
        // 
        this.lblSoNha.AutoSize = true;
        this.lblSoNha.Location = new System.Drawing.Point(10, 10);
        this.lblSoNha.Name = "lblSoNha";
        this.lblSoNha.Size = new System.Drawing.Size(41, 15);
        this.lblSoNha.TabIndex = 0;
        this.lblSoNha.Text = "Số nhà:";
        // 
        // txtSoNha
        // 
        this.txtSoNha.Location = new System.Drawing.Point(10, 28);
        this.txtSoNha.Name = "txtSoNha";
        this.txtSoNha.Size = new System.Drawing.Size(300, 23);
        this.txtSoNha.TabIndex = 1;
        // 
        // lblDuong
        // 
        this.lblDuong.AutoSize = true;
        this.lblDuong.Location = new System.Drawing.Point(10, 58);
        this.lblDuong.Name = "lblDuong";
        this.lblDuong.Size = new System.Drawing.Size(40, 15);
        this.lblDuong.TabIndex = 2;
        this.lblDuong.Text = "Đường:";
        // 
        // txtDuong
        // 
        this.txtDuong.Location = new System.Drawing.Point(10, 76);
        this.txtDuong.Name = "txtDuong";
        this.txtDuong.Size = new System.Drawing.Size(300, 23);
        this.txtDuong.TabIndex = 3;
        this.txtDuong.TextChanged += new System.EventHandler(this.txtDuong_TextChanged);
        // 
        // lblPhuong
        // 
        this.lblPhuong.AutoSize = true;
        this.lblPhuong.Location = new System.Drawing.Point(10, 106);
        this.lblPhuong.Name = "lblPhuong";
        this.lblPhuong.Size = new System.Drawing.Size(38, 15);
        this.lblPhuong.TabIndex = 4;
        this.lblPhuong.Text = "Phường:";
        // 
        // txtPhuong
        // 
        this.txtPhuong.Location = new System.Drawing.Point(10, 124);
        this.txtPhuong.Name = "txtPhuong";
        this.txtPhuong.Size = new System.Drawing.Size(300, 23);
        this.txtPhuong.TabIndex = 5;
        // 
        // lblQuan
        // 
        this.lblQuan.AutoSize = true;
        this.lblQuan.Location = new System.Drawing.Point(10, 154);
        this.lblQuan.Name = "lblQuan";
        this.lblQuan.Size = new System.Drawing.Size(31, 15);
        this.lblQuan.TabIndex = 6;
        this.lblQuan.Text = "Quận:";
        // 
        // txtQuan
        // 
        this.txtQuan.Location = new System.Drawing.Point(10, 172);
        this.txtQuan.Name = "txtQuan";
        this.txtQuan.Size = new System.Drawing.Size(300, 23);
        this.txtQuan.TabIndex = 7;
        // 
        // lblThanhPho
        // 
        this.lblThanhPho.AutoSize = true;
        this.lblThanhPho.Location = new System.Drawing.Point(10, 202);
        this.lblThanhPho.Name = "lblThanhPho";
        this.lblThanhPho.Size = new System.Drawing.Size(70, 15);
        this.lblThanhPho.TabIndex = 8;
        this.lblThanhPho.Text = "Thành phố:";
        // 
        // txtThanhPho
        // 
        this.txtThanhPho.Location = new System.Drawing.Point(10, 220);
        this.txtThanhPho.Name = "txtThanhPho";
        this.txtThanhPho.Size = new System.Drawing.Size(300, 23);
        this.txtThanhPho.TabIndex = 9;
        // 
        // AddressControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.txtThanhPho);
        this.Controls.Add(this.lblThanhPho);
        this.Controls.Add(this.txtQuan);
        this.Controls.Add(this.lblQuan);
        this.Controls.Add(this.txtPhuong);
        this.Controls.Add(this.lblPhuong);
        this.Controls.Add(this.txtDuong);
        this.Controls.Add(this.lblDuong);
        this.Controls.Add(this.txtSoNha);
        this.Controls.Add(this.lblSoNha);
        this.Name = "AddressControl";
        this.Size = new System.Drawing.Size(330, 260);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblSoNha;
    private System.Windows.Forms.TextBox txtSoNha;
    private System.Windows.Forms.Label lblDuong;
    private System.Windows.Forms.TextBox txtDuong;
    private System.Windows.Forms.Label lblPhuong;
    private System.Windows.Forms.TextBox txtPhuong;
    private System.Windows.Forms.Label lblQuan;
    private System.Windows.Forms.TextBox txtQuan;
    private System.Windows.Forms.Label lblThanhPho;
    private System.Windows.Forms.TextBox txtThanhPho;
}