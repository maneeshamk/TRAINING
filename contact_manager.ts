// Contact interface
interface Contact {
  id: number;
  name: string;
  email: string;
  phone: string;
}

// ContactManager class
class ContactManager {
  private contacts: Contact[] = [];

  addContact(contact: Contact): void {
    this.contacts.push(contact);
    console.log(" Contact added successfully!");
  }

  viewContacts(): Contact[] {
    return this.contacts;
  }

  modifyContact(id: number, updatedContact: Partial<Contact>): void {
    const contactIndex = this.contacts.findIndex(c => c.id === id);
    if (contactIndex === -1) {
      console.error(" Contact not found!");
      return;
    }
    this.contacts[contactIndex] = { ...this.contacts[contactIndex], ...updatedContact };
    console.log(" Contact updated successfully!");
  }

  deleteContact(id: number): void {
    const contactIndex = this.contacts.findIndex(c => c.id === id);
    if (contactIndex === -1) {
      console.error(" Contact not found!");
      return;
    }
    this.contacts.splice(contactIndex, 1);
    console.log("🗑️ Contact deleted successfully!");
  }
}

//testing
const manager = new ContactManager();

manager.addContact({ id: 1, name: "Maneesha", email: "maneesha@example.com", phone: "1234567890" });
manager.addContact({ id: 2, name: "John Doe", email: "john@example.com", phone: "9876543210" });

console.log(manager.viewContacts());

manager.modifyContact(1, { phone: "1111111111" });
console.log(manager.viewContacts());

manager.deleteContact(2);
console.log(manager.viewContacts());


