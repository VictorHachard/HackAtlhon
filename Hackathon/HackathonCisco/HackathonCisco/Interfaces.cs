﻿namespace HackathonCisco
{
    class Interfaces
    {
        private TypeOfInterfaces typeOfInterfaces;
        private int preInterfaces;
        private int postInterfaces;
        private bool active = false;
        private string description;
        private IP ip;
        private IP mask;

        public TypeOfInterfaces TypeOfInterfaces { get => typeOfInterfaces; set => typeOfInterfaces = value; }
        public int PreInterfaces { get => preInterfaces; set => preInterfaces = value; }
        public int PostInterfaces { get => postInterfaces; set => postInterfaces = value; }
        public bool Active { get => active; set => active = value; }
        public string Description { get => description; set => description = value; }
        public IP Ip { get => ip; set => ip = value; }
        public IP Mask { get => mask; set => mask = value; }

        public Interfaces(TypeOfInterfaces typeOfInterfaces, int preInterfaces, int postInterfaces, bool active, string description, IP ip, IP mask)
        {
            TypeOfInterfaces = typeOfInterfaces;
            PreInterfaces = preInterfaces;
            PostInterfaces = postInterfaces;
            Active = active;
            Description = description;
            Ip = ip;
            Mask = mask;
        }

        public Interfaces(TypeOfInterfaces typeOfInterfaces, int preInterfaces, int postInterfaces, bool active, string description, string ip, string mask)
        {
            TypeOfInterfaces = typeOfInterfaces;
            PreInterfaces = preInterfaces;
            PostInterfaces = postInterfaces;
            Active = active;
            Description = description;
            Ip = new IP(ip);
            Mask = new IP(mask);
        }

        public string GetActiveString()
        {
            return this.Active ? "no shutdown" : "shutdown";
        }

        public new string ToString()
        {
            string res = "";
            res += "interface " + this.TypeOfInterfaces + " " + this.PreInterfaces + "/" + this.PostInterfaces + "\n";
            res += "ip address " + this.Ip.ToString() + " " + this.Mask.ToString() + "\n";
            res += "description " + this.Description + "\n";
            res += this.GetActiveString() + "\n";
            return res;
        }
    }
}