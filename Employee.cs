namespace ObjectsCompare
{
    class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public static bool operator ==(Employee Lhand, Employee Rhand)
        {
            return Lhand.Equals(Rhand);
        }
        public static bool operator !=(Employee Lhand, Employee Rhand)
        {
            return !(Lhand.Equals(Rhand));
        }

        #region Overrided Funcs
        public override bool Equals(object obj)
        {
            if ((obj is null) || !(obj is Employee))
                return false;
            var emp = obj as Employee;
            return
                this.ID == emp.ID &&
                this.Name == emp.Name &&
                this.Salary == emp.Salary &&
                this.Department == emp.Department;
        }
        public override int GetHashCode()
        {
            // We used Prime Numbers to make it unique.
            int hash = 9;
            hash = (hash * 7) + this.ID.GetHashCode();
            hash = (hash * 7) + this.Name.GetHashCode();
            hash = (hash * 7) + this.Salary.GetHashCode();
            hash = (hash * 7) + this.Department.GetHashCode();
            return hash;
        }
        #endregion
    }
}
