using MyWinFormsApp.Services;

namespace MyWinFormsApp.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Handles the Save button click event
    /// </summary>
    private void btnSave_Click(object? sender, EventArgs e)
    {
        try
        {
            // Get address from the control
            var address = addressControl1.GetAddress();

            // Validate that at least some fields are filled
            if (string.IsNullOrWhiteSpace(address.SoNha) &&
                string.IsNullOrWhiteSpace(address.Duong) &&
                string.IsNullOrWhiteSpace(address.Phuong) &&
                string.IsNullOrWhiteSpace(address.Quan) &&
                string.IsNullOrWhiteSpace(address.ThanhPho))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một trường thông tin!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build full address string
            string fullAddress = AddressService.BuildFullAddress(address);

            // Display result
            txtResult.Text = fullAddress;

            MessageBox.Show("Đã lưu địa chỉ thành công!", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}