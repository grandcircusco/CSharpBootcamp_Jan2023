using Access;

Government GCGov = new Government();
//GCGov.SecretAgents; //Cannot Access because private
GCGov.DisplayAllStaff();
Console.WriteLine(GCGov.IsSecretAgent("Josh"));