using System;
using System.Windows;
using DevExpress.Xpf.Scheduler;
using DevExpress.XtraScheduler;

namespace WpfApplication1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            SchedulerStorage schedulerStorage = schedulerControl1.Storage;
            Appointment apt = schedulerStorage.CreateAppointment(AppointmentType.Normal);
            DateTime baseTime = DateTime.Today;

            apt.Start = baseTime.AddHours(1);
            apt.End = baseTime.AddHours(3.5);
            apt.Subject = "Appointment Subject";
            apt.Location = "Appointment Location";
            apt.Description = "Appointment description";

            schedulerStorage.Appointments.Add(apt);

            schedulerControl1.Start = apt.Start.Date;
            schedulerControl1.ActiveView.SelectAppointment(apt);
        }
    }
}
