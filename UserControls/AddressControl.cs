using MyWinFormsApp.Models;
using MyWinFormsApp.Services;

namespace MyWinFormsApp.UserControls;

public partial class AddressControl : UserControl
{
    public AddressControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Gets the address data from all text boxes
    /// </summary>
    public Address GetAddress()
    {
        return new Address
        {
            SoNha = txtSoNha.Text,
            Duong = txtDuong.Text,
            Phuong = txtPhuong.Text,
            Quan = txtQuan.Text,
            ThanhPho = txtThanhPho.Text
        };
    }

    /// <summary>
    /// Sets the address data to all text boxes
    /// </summary>
    public void SetAddress(Address address)
    {
        txtSoNha.Text = address.SoNha;
        txtDuong.Text = address.Duong;
        txtPhuong.Text = address.Phuong;
        txtQuan.Text = address.Quan;
        txtThanhPho.Text = address.ThanhPho;
    }

    /// <summary>
    /// Clears all text boxes
    /// </summary>
    public void Clear()
    {
        txtSoNha.Text = string.Empty;
        txtDuong.Text = string.Empty;
        txtPhuong.Text = string.Empty;
        txtQuan.Text = string.Empty;
        txtThanhPho.Text = string.Empty;
    }

    /// <summary>
    /// Handles TextChanged event for street name to auto-transform "NCV"
    /// </summary>
    private void txtDuong_TextChanged(object? sender, EventArgs e)
    {
        string normalizedText = AddressService.NormalizeStreet(txtDuong.Text);
        
        // Only update if text changed to avoid infinite loop
        if (txtDuong.Text != normalizedText)
        {
            int cursorPosition = txtDuong.SelectionStart;
            txtDuong.Text = normalizedText;
            txtDuong.SelectionStart = txtDuong.Text.Length;
        }
    }
}