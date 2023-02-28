'Choctaw Nation Help Desk Network Connectivity Tool
'Designed and programmed by David Coxsey
'For the use by the Choctaw Nation IT Department
'Any unauthorized coping is prohibited.
Imports System.Net.Dns
Imports System.Management

Public Class Form1


    Private Sub DisplayAvailability(ByVal available As Boolean)
        'Display the Availability of a network connection
        Label1.Text = available.ToString
    End Sub

    Private Sub MyComputerNetwork_NetworkAvailabilityChanged( _
        ByVal sender As Object, _
        ByVal e As Devices.NetworkAvailableEventArgs)
        'checks the network cards on the computer and the calls the function to display network availability
        DisplayAvailability(e.IsNetworkAvailable)
    End Sub

    Private Sub Handle_NetworkAvailabilityChanged()
        AddHandler My.Computer.Network.NetworkAvailabilityChanged, _
           AddressOf MyComputerNetwork_NetworkAvailabilityChanged
        DisplayAvailability(My.Computer.Network.IsAvailable)
        'Handles MyComputerNetwork_NetworkAvailabilityChanged Sub
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStripStatusLabel1.Text = "Program Created By David Coxsey (dcoxsey@choctawnation.com)"
        refresh_form()

    End Sub
    Function GetUserName() As String
        'Function will pull the current Windows user name, which is in the DOMAIN\USERNAME
        'format.  It then splits that string and returns the username as a string.
        'If the user isn't currently on a domain, it only returns their username.
        If TypeOf My.User.CurrentPrincipal Is _
        Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function
    Function GetUserDomain() As String
        'works the same as the GetUserName function, but returns the domain account
        If TypeOf My.User.CurrentPrincipal Is Security.Principal.WindowsPrincipal Then
            Dim parts() As String = Split(My.User.Name, "\")
            Dim domain As String = parts(0)
            If domain = "CHOCTAWNATION" Then
                Return "Yes"
            Else
                'the user is not on the domain
                Return "Not on the Domain."
            End If

        Else
            'the user is not on the domain
            Return "Not on the Domain."
        End If
    End Function

   
    Private Sub refresh_form()
        'Sub will refresh all of the labels and display the current settings.
        Try
            Handle_NetworkAvailabilityChanged()
       
            'Grabs the full name of the current running os
            Label2.Text = My.Computer.Info.OSFullName

            Label6.Text = GetUserName()
            Label8.Text = GetUserDomain()
            mac.Text = GetMac()

            'Checks to see if they are on the Choctaw Nation complex network by pinging the core router

            If My.Computer.Network.Ping("10.1.0.74") Then
                Label10.Text = "Yes"
            Else
                Label10.Text = "No"
            End If
            GetIPAddress()
            GetSubNet()
            GetDefaultGateway()
        Catch ex As Exception
            Dim warn As String = "You have no network connection.  Possible problems could be one of the following:  " + _
            vbNewLine + "1) Your Network Interface Card (NIC) is either disabled or faulty." + _
            vbNewLine + "2) The ethernet cable that connects your computer to the network is either unplugged or has been damaged." + _
            vbNewLine + "3) The network connection for your immediate area is down.  Check with those around you to see if they can connect." + _
            vbNewLine + "Please let the Choctaw Nation IT Help Desk know of the issue by calling ext. 2195 at the main complex"
            MessageBox.Show(warn, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()

        End Try
    End Sub
    Sub GetDefaultGateway()
        'Calls the WMI class that will find the computer's subnetmask
        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")

        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

        Dim objMO As ManagementObject

        Dim df As String()
        Dim macadd As String()

        For Each objMO In objMOC

            df = CType(objMO("DefaultIPGateway"), String())


            If df IsNot Nothing Then


                Dim defaultgate As String = df(0)
                defaultgateway.Text = df(0)



            End If

        Next
    End Sub
    Function GetIPAddress() As String
        'Function will find and display the computer name and a list of all the ips
        'of the current system, if there is more than one.
        Dim myHost As String = GetHostName()
        Dim myIPs As System.Net.IPHostEntry = GetHostEntry(myHost)


        For Each myip As System.Net.IPAddress In myIPs.AddressList
            If myip.ToString = "127.0.0.1" Then
                'if the computer doesn't have an ip address,
                'I have set up to display 0.0.0.0 instead of the lookback address
                'as to not confuse the end user
                ipaddress.Text = "0.0.0.0" + vbNewLine
            Else
                ipaddress.Text = myip.ToString + vbNewLine
            End If

        Next

        'Displays the current computer name
        Label12.Text = myHost.ToString
        Return 0
    End Function

    Private Sub renew()
        'Sub calls the command prompt and inputs the ipconfig.exe /renew command
        Dim sCommand As String = System.Environment.SystemDirectory & "\IPConfig.exe /renew"
        Shell(sCommand, AppWinStyle.Hide, True)
    End Sub
    Private Sub release()
        'Sub calls the command prompt and inputs the ipconfig.exe /release command
        Dim sCommand As String = System.Environment.SystemDirectory & "\IpConfig.exe /release"
        Shell(sCommand, AppWinStyle.Hide, True)
    End Sub
    
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Calls the release ip command and refreshes the form
        release()
        refresh_form()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Calls the renew ip command and refreshes the form
        renew()
        refresh_form()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Sub will send a ping to www.yahoo.com to see if the computer has an outside internet connection.
        If My.Computer.Network.Ping("209.191.93.52") Then
            ping.Text = "Ping Test Successful!"
            ping.Visible = True
        Else
            ping.Text = "Ping Test Failed!"
            ping.Visible = True
        End If
    End Sub

    Private Sub GetSubNet()
        'Calls the WMI class that will find the computer's subnetmask
        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")

        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

        Dim objMO As ManagementObject

        Dim subnets As String()
        Dim caption As String

        For Each objMO In objMOC
            caption = objMO.Item("Caption").ToString.Substring(11)
            If caption = "Bluetooth Device (Personal Area Network)" Then
                Exit For
            End If
            subnets = CType(objMO("IPSubnet"), String())
            If subnets IsNot Nothing Then
                Dim subneter As String = subnets(0)
                subnet.Text = subneter
            End If
        Next

    End Sub

   
    
   
    Function GetMac() As String
        Dim mc As System.Management.ManagementClass
        Dim mo As ManagementObject
        mc = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim x As String = ""
        For Each mo In moc
            If mo.Item("IPEnabled") = True Then
                Dim strAdapter As String
                strAdapter = mo.Item("Caption").ToString().Substring(11)
                If strAdapter = "Bluetooth Device (Personal Area Network)" Then
                    Exit For
                End If
                x = mo.Item("MacAddress").ToString()

            End If
        Next
        Return x
    End Function

   
    Private Sub flush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flush.Click
        'Sub will flush the client's DNS cache
        'Sub calls the command prompt and inputs the ipconfig.exe /release command
        Dim sCommand As String = System.Environment.SystemDirectory & "\IpConfig.exe /flushdns"
        Shell(sCommand, AppWinStyle.Hide, True)
        refresh_form()
    End Sub

    Private Sub register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles register.Click
        'Sub calls the command prompt and inputs the ipconfig.exe /release command
        Dim sCommand As String = System.Environment.SystemDirectory & "\IpConfig.exe /registerdns"
        Shell(sCommand, AppWinStyle.Hide, True)
        refresh_form()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        trace.Show()
    End Sub
End Class
