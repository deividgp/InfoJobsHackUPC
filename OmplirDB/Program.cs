using InfoJobsHackUPC.Entities;
using OmplirDB;

using (var context = new AppDbContext())
{
    context.Add(new Profile(){
        Field = "hola",
        Id = 1,
        Name = "Hola",
    });
    context.SaveChanges();
}