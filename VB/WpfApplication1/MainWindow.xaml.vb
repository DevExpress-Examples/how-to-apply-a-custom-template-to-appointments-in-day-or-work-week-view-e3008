Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports DevExpress.Xpf.Scheduler
Imports DevExpress.XtraScheduler

Namespace WpfApplication1
    Partial Public Class MainWindow
        Inherits Window
        Public Sub New()
            InitializeComponent()

            Dim schedulerStorage As SchedulerStorage = schedulerControl1.Storage
            Dim apt As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Normal)
            Dim baseTime As DateTime = DateTime.Today

            apt.Start = baseTime.AddHours(1)
            apt.End = baseTime.AddHours(3.5)
            apt.Subject = "Appointment Subject"
            apt.Location = "Appointment Location"
            apt.Description = "Appointment description"

            schedulerStorage.AppointmentStorage.Add(apt)

            schedulerControl1.Start = apt.Start.Date
            schedulerControl1.ActiveView.SelectAppointment(apt)
        End Sub
    End Class
End Namespace
