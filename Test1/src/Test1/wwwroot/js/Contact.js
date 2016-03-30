function ContactManager() {
    this.FirstName = "";
    this.LastName = "";
    this.Age = 0;

    this.GetContactDetails = function ContactInfo() {
        return this.FirstName + " " + this.LastName;
    }
}