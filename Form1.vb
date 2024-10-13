Public Class Form1

    '***********************************************************************************
    ' *********************************  PUNCH LIST  ***********************************
    '***********************************************************************************
    ' ___ Create the GetCPU( ) function to return a Double value reflecting the price of
    '        the selected CPU.
    ' ___ Create the GetGPU( ) function to return a Double value reflecting the price of
    '        the selected graphic display card.
    ' ___ Create the UpdateRAMPrice( ) sub procedure to modify the ram class variable by
    '        REFERENCE to reflect the amount of RAM chosen.
    ' ___ Complete the GetOS( ) function to return a Double value using the  myOS parameter
    '        value to reflect the price of the selected operating system to be installed.
    ' ___ Create the GetSSD( ) function to return a Double value reflecting the price of
    '        the selected storge.
    ' ___ Create the UpdatePriceWIthWarranty(base) sub procedure to modify the base class
    '        level variable by REFERENCE to reflect the warranty percentage added to the
    '        subtotal of the calculated base subtotal of the configured computer.
    ' *******************************  END PUNCH LIST **********************************

    Private Sub UpdatePrice(sender As Object, e As EventArgs) Handles rbCPU3.CheckedChanged,
        rbCPU2.CheckedChanged, rbCPU1.CheckedChanged, rbOSPro.CheckedChanged,
        rbOSHome.CheckedChanged, rbGPU4.CheckedChanged, rbGPU3.CheckedChanged,
        rbGPU2.CheckedChanged, rbGPU1.CheckedChanged, rbWarranty4.CheckedChanged,
        rbWarranty3.CheckedChanged, rbWarranty2.CheckedChanged, rbWarranty1.CheckedChanged,
        rbRAM64.CheckedChanged, rbRAM32.CheckedChanged, rbRAM16.CheckedChanged,
        rbSSD4.CheckedChanged, rbSSD2.CheckedChanged, rbSSD1.CheckedChanged
        '************************ IMPORTANT INSTRUCTIONS  ******************************
        '*** Do NOT make any changes to this event handler. Complete the program by  ***
        '*** writing the methods (subprocedures and functions referenced in the code ***
        '*** below and following the instructions in the coomments below.            ***
        '*******************************************************************************
        Dim base, cpu, os, gpu, ram, ssd As Double
        base = 699.0
        cpu = GetCPU() ' Write the GetCPU function with no parameter
        Dim osVersion As String = If(rbOSPro.Checked, "Pro", "Home")
        os = GetOS(osVersion) ' Complete the GetOS(myOS As String) function below
        gpu = GetGPU()   'Write the GetCPU function with no parameter
        Dim myRAM As Integer = If(rbRAM32.Checked, 32, 16)
        myRAM = If(rbRAM64.Checked, 64, myRAM)
        UpdateRAMPrice(ram) ' Write subprocedure to modify the ram class variable ByReference
        ssd = GetSSD() ' Write the GetCPU function with no parameter
        base += cpu + os + gpu + ram + ssd
        UpdatePriceWithWarranty(base)  ' Write the SubProcedure with base passed by Reference
        lblPrice.Text = base.ToString("C2")
    End Sub

    Private Function GetOS(ByVal myOS As String) As Double
        'Complete this method using the myOs parameter value
        'Make NO references to the radio button controls

    End Function
End Class
