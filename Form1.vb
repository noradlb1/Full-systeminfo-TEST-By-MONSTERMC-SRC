Public Class Form1

    '  _____________________________________________________________________________________________________________________________________________________________________________________________________________________________
    '  _________/\____\_________________/::\____\_________________/\____\__________________/\____\______________/\____\__________________/\____\__________________/\____\__________________/\____\__________________/\____\_________
    '  ________/::\____\_______________/::::\____\_______________/::\____\________________/::\____\____________/::\____\________________/::\____\________________/::\____\________________/::\____\________________/::\____\________
    '  _______/::::|___|______________/::::::\____\_____________/::::|___|_______________/::::\____\___________\:::\____\______________/::::\____\______________/::::\____\______________/::::|___|_______________/::::\____\_______
    '  ______/:::::|___|_____________/::::::::\____\___________/:::::|___|______________/::::::\____\___________\:::\____\____________/::::::\____\____________/::::::\____\____________/:::::|___|______________/::::::\____\______
    '  _____/::::::|___|____________/:::/~~\:::\____\_________/::::::|___|_____________/:::/\:::\____\___________\:::\____\__________/:::/\:::\____\__________/:::/\:::\____\__________/::::::|___|_____________/:::/\:::\____\_____
    '  ____/:::/|::|___|___________/:::/____\:::\____\_______/:::/|::|___|____________/:::/__\:::\____\___________\:::\____\________/:::/__\:::\____\________/:::/__\:::\____\________/:::/|::|___|____________/:::/__\:::\____\____
    '  ___/:::/_|::|___|__________/:::/____/_\:::\____\_____/:::/_|::|___|____________\:::\___\:::\____\__________/::::\____\______/::::\___\:::\____\______/::::\___\:::\____\______/:::/_|::|___|___________/:::/____\:::\____\___
    '  __/:::/__|::|___|_________/:::/____/___\:::\____\___/:::/__|::|___|_____________\:::\___\:::\____\________/::::::\____\____/::::::\___\:::\____\____/::::::\___\:::\____\____/:::/__|::|___|__________/:::/____/_\:::\____\__
    '  _/:::/___|::::::::\____\_|:::|____|_____|:::|____|_/:::/___|::|___|/\____\__/\___\:::\___\:::\____\______/:::/\:::\____\__/:::/\:::\___\:::\____\__/:::/\:::\___\:::\____\__/:::/___|::::::::\____\__/:::/____/___\:::\____\_
    '  /:::/____|:::::::::\____\|:::|____|_____|:::|____|/::_/____|::|___/::\____\/::\___\:::\___\:::\____\____/:::/__\:::\____\/:::/__\:::\___\:::\____\/:::/__\:::\___\:::|____|/:::/____|:::::::::\____\/:::/____/_____\:::\____\
    '  \::/____/_~~~~~/:::/____/_\:::\____\___/:::/____/_\::/____/|::|__/:::/____/\:::\___\:::\___\::/____/___/:::/____\::/____/\:::\___\:::\___\::/____/\::/___|::::\__/:::|____|\::/____/_~~~~~/:::/____/\:::\____\______\::/____/
    '  _\/____/______/:::/____/___\:::\____\_/:::/____/___\/____/_|::|_/:::/____/__\:::\___\:::\___\/____/___/:::/____/_\/____/__\:::\___\:::\___\/____/__\/____|:::::\/:::/____/__\/____/______/:::/____/__\:::\____\______\/____/_
    '  _____________/:::/____/_____\:::\____/:::/____/____________|::|/:::/____/____\:::\___\:::\____\______/:::/____/____________\:::\___\:::\____\____________|:::::::::/____/_______________/:::/____/____\:::\____\_____________
    '  ____________/:::/____/_______\:::\__/:::/____/_____________|::::::/____/______\:::\___\:::\____\____/:::/____/______________\:::\___\:::\____\___________|::|\::::/____/_______________/:::/____/______\:::\____\____________
    '  ___________/:::/____/_________\::::::::/____/______________|:::::/____/________\:::\__/:::/____/____\::/____/________________\:::\___\::/____/___________|::|_\::/____/_______________/:::/____/________\:::\____\___________
    '  __________/:::/____/___________\::::::/____/_______________|::::/____/__________\:::\/:::/____/______\/____/__________________\:::\___\/____/____________|::|__~|____________________/:::/____/__________\:::\____\__________
    '  _________/:::/____/_____________\::::/____/________________/:::/____/____________\::::::/____/_________________________________\:::\____\________________|::|___|___________________/:::/____/____________\:::\____\_________
    '  ________/:::/____/_______________\::/____/________________/:::/____/______________\::::/____/___________________________________\:::\____\_______________\::|___|__________________/:::/____/______________\:::\____\________
    '  ________\::/____/_________________~~______________________\::/____/________________\::/____/_____________________________________\::/____/________________\:|___|__________________\::/____/________________\::/____/________
    '  _________\/____/___________________________________________\/____/__________________\/____/_______________________________________\/____/__________________\|___|___________________\/____/__________________\/____/_________
    '  _____________________________________________________________________________________________________________________________________________________________________________________________________________________________


    ' run it as admin if u got some problems

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Add("user Name")
        ListView1.Items(0).SubItems.Add(My.User.Name)
        ListView1.Items.Add("my computer name")
        ListView1.Items(1).SubItems.Add(My.Computer.Name)
        ListView1.Items.Add("Available Physical Memory")
        ListView1.Items(2).SubItems.Add(My.Computer.Info.AvailablePhysicalMemory)
        ListView1.Items.Add("Available Virtual Memory")
        ListView1.Items(3).SubItems.Add(My.Computer.Info.AvailableVirtualMemory)
        ListView1.Items.Add("OS Full Name")
        ListView1.Items(4).SubItems.Add(My.Computer.Info.OSFullName)
        ListView1.Items.Add("OS Platform")
        ListView1.Items(5).SubItems.Add(My.Computer.Info.OSPlatform)
        ListView1.Items.Add("OS Version")
        ListView1.Items(6).SubItems.Add(My.Computer.Info.OSVersion)
        ListView1.Items.Add("Total Physical Memory")
        ListView1.Items(7).SubItems.Add(My.Computer.Info.TotalPhysicalMemory)
        ListView1.Items.Add("Total Virtual Memory")
        ListView1.Items(8).SubItems.Add(My.Computer.Info.TotalVirtualMemory)
        ListView1.Items.Add("ClipBoard Text")
        ListView1.Items(9).SubItems.Add(My.Computer.Clipboard.GetText)
        ListView1.Items.Add("Local Date and Time")
        ListView1.Items(10).SubItems.Add(My.Computer.Clock.LocalTime)
        ListView1.Items.Add("Current File Directory")
        ListView1.Items(11).SubItems.Add(My.Computer.FileSystem.CurrentDirectory)
        ListView1.Items.Add("CapsLock On or Off")
        ListView1.Items(12).SubItems.Add(My.Computer.Keyboard.CapsLock)
        ListView1.Items.Add("NumLock On or Off")
        ListView1.Items(13).SubItems.Add(My.Computer.Keyboard.NumLock)
        ListView1.Items.Add("ScrollLock On or Off")
        ListView1.Items(14).SubItems.Add(My.Computer.Keyboard.ScrollLock)
        ListView1.Items.Add("Mouse Wheel")
        ListView1.Items(15).SubItems.Add(My.Computer.Mouse.WheelExists)
        ListView1.Items.Add("Language")
        ListView1.Items(16).SubItems.Add(My.Computer.Info.InstalledUICulture.ToString)
        ListView1.Items.Add("BitsPerPixel")
        ListView1.Items(17).SubItems.Add(My.Computer.Screen.BitsPerPixel)
        ListView1.Items.Add("Registry CurrentConfig Name")
        ListView1.Items(18).SubItems.Add(My.Computer.Registry.CurrentConfig.Name)
        ListView1.Items.Add("Registry CurrentUser Name")
        ListView1.Items(19).SubItems.Add(My.Computer.Registry.CurrentUser.Name)
        ListView1.Items.Add("Registry ClassesRoot Name")
        ListView1.Items(20).SubItems.Add(My.Computer.Registry.ClassesRoot.Name)
        ListView1.Items.Add("Registry LocalMachine Name")
        ListView1.Items(21).SubItems.Add(My.Computer.Registry.LocalMachine.Name)
        ListView1.Items.Add("Registry PerformanceData Name")
        ListView1.Items(22).SubItems.Add(My.Computer.Registry.PerformanceData.Name)
        ListView1.Items.Add("Registry Users Name")
        ListView1.Items(23).SubItems.Add(My.Computer.Registry.Users.Name)
        ListView1.Items.Add("Keyboard ShiftKeyDown")
        ListView1.Items(24).SubItems.Add(My.Computer.Keyboard.ShiftKeyDown)
        ListView1.Items.Add("Keyboard CtrlKeyDown")
        ListView1.Items(25).SubItems.Add(My.Computer.Keyboard.CtrlKeyDown)
        ListView1.Items.Add("Keyboard AltKeyDown")
        ListView1.Items(26).SubItems.Add(My.Computer.Keyboard.AltKeyDown)
        ListView1.Items.Add("Ports.GetHashCode")
        ListView1.Items(27).SubItems.Add(My.Computer.Ports.GetHashCode())
        ListView1.Items.Add("Screen.DeviceName")
        ListView1.Items(28).SubItems.Add(My.Computer.Screen.DeviceName)
        ListView1.Items.Add("Screen.Primary")
        ListView1.Items(29).SubItems.Add(My.Computer.Screen.Primary)
        ListView1.Items.Add("ComputerName")
        ListView1.Items(30).SubItems.Add(SystemInformation.ComputerName)
        ListView1.Items.Add("Network")
        ListView1.Items(31).SubItems.Add(SystemInformation.Network.ToString())
        ListView1.Items.Add("UserDomainName")
        ListView1.Items(32).SubItems.Add(SystemInformation.UserDomainName)
        ListView1.Items.Add("UserName")
        ListView1.Items(33).SubItems.Add(SystemInformation.UserName)
        ListView1.Items.Add("BootMode")
        ListView1.Items(34).SubItems.Add(SystemInformation.BootMode.ToString())
        ListView1.Items.Add("MenuFont")
        ListView1.Items(35).SubItems.Add(SystemInformation.MenuFont.ToString())
        ListView1.Items.Add("MonitorCount")
        ListView1.Items(36).SubItems.Add(SystemInformation.MonitorCount.ToString())
        ListView1.Items.Add("MonitorsSameDisplayFormat")
        ListView1.Items(37).SubItems.Add(SystemInformation.MonitorsSameDisplayFormat.ToString())
        ListView1.Items.Add("ArrangeDirection")
        ListView1.Items(38).SubItems.Add(SystemInformation.ArrangeDirection.ToString())
        ListView1.Items.Add("MousePresent")
        ListView1.Items(39).SubItems.Add(SystemInformation.MousePresent.ToString())
        ListView1.Items.Add("MouseButtonsSwapped")
        ListView1.Items(40).SubItems.Add(SystemInformation.MouseButtonsSwapped.ToString())
        ListView1.Items.Add("UserInteractive")
        ListView1.Items(41).SubItems.Add(SystemInformation.UserInteractive.ToString())
        ListView1.Items.Add("VirtualScreen")
        ListView1.Items(42).SubItems.Add(SystemInformation.VirtualScreen.ToString())
        ListView1.Items.Add("KeyboardSpeed")
        ListView1.Items(43).SubItems.Add(SystemInformation.KeyboardSpeed())
        ListView1.Items.Add("CurrentDirectory")
        ListView1.Items(44).SubItems.Add(My.Computer.FileSystem.CurrentDirectory)
        ListView1.Items.Add("Keyboard KeyDown")
        ListView1.Items(45).SubItems.Add(My.Computer.Keyboard.AltKeyDown)
        ListView1.Items.Add("Keyboard ShiftKeyDown")
        ListView1.Items(46).SubItems.Add(My.Computer.Keyboard.ShiftKeyDown)

    End Sub
End Class
