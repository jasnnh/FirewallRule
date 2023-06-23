string str = "advfirewall firewall add rule name=" + "\"Port for SQL\"" + " dir=in action=allow protocol=TCP localport=63000";
ProcessStartInfo psi = new ProcessStartInfo();
Process process = new Process();

psi.FileName = "netsh";
psi.WindowStyle = ProcessWindowStyle.Normal;
psi.Arguments = str;

process.StartInfo = psi;
process.Start();

process.WaitForExit();