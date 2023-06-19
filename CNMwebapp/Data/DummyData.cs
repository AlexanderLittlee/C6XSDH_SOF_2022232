using CNMwebapp.Data;
using CNMwebapp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCore.Data
{
    public class DummyData
    {
        public static Random r = new Random();

        public static string GeneratePhoneNumber()
        {
            string phonenumber="";
            int provider = r.Next(1, 4);
            switch (provider)
            {
                case 1:
                    phonenumber += "20";
                    break;
                case 2:
                    phonenumber += "30";
                    break;
                case 3:
                    phonenumber += "70";
                    break;
                default:
                    phonenumber += "70";
                    break;
            }
            provider = r.Next(1000000, 10000000);
            phonenumber += provider.ToString();
            return phonenumber;
        }

        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<Worker> userManager,
                              RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();


            var role = new IdentityRole()
            {
                Name = "Admin"
            };

            string password = "asdasdasd";

            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(role);


            //-------------------------ADMINS--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            if (await userManager.FindByNameAsync("wimmer@gabor.com") == null)
            {
                var user = new Worker
                {
                    UserName = "wimmer@gabor.com",
                    Email = "wimmer@gabor.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Wimmer Gábor",
                    Age = 36,
                    DriversLicence = true,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }

            if (await userManager.FindByNameAsync("mayer@attila.com") == null)
            {
                var user = new Worker
                {
                    UserName = "mayer@attila.com",
                    Email = "mayer@attila.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Mayer Attila",
                    Age = 39,
                    DriversLicence = false,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }

            if (await userManager.FindByNameAsync("hidasi@mate.com") == null)
            {
                var user = new Worker
                {
                    UserName = "hidasi@mate.com",
                    Email = "hidasi@mate.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Hidasi Máté",
                    Age = 36,
                    DriversLicence = true,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }

            //-------------------------USERS--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            if (await userManager.FindByNameAsync("kiss@tibor.com") == null)
            {
                var user = new Worker
                {
                    UserName = "kiss@tibor.com",
                    Email = "kiss@tibor.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Kiss Tibor",
                    Age = 26,
                    DriversLicence = false,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

            if (await userManager.FindByNameAsync("kiss@sanyi.com") == null)
            {
                var user = new Worker
                {
                    UserName = "kiss@sanyi.com",
                    Email = "kiss@sanyi.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name= "Kiss Sanyi",
                    Age=23,
                    DriversLicence = true,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

            if (await userManager.FindByNameAsync("gulyas@donat.com") == null)
            {
                var user = new Worker
                {
                    UserName = "gulyas@donat.com",
                    Email = "gulyas@donat.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Gulyás Donát",
                    Age = 25,
                    DriversLicence = true,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

            if (await userManager.FindByNameAsync("deak@zoltan.com") == null)
            {
                var user = new Worker
                {
                    UserName = "deak@zoltan.com",
                    Email = "deak@zoltan.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Deák Zoltán",
                    Age = 25,
                    DriversLicence = false,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

            if (await userManager.FindByNameAsync("logan@logan.com") == null)
            {
                var user = new Worker
                {
                    UserName = "logan@logan.com",
                    Email = "logan@logan.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Hudák Zoltán Logan",
                    Age = 19,
                    DriversLicence = false,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

            if (await userManager.FindByNameAsync("kovacs@kevin.com") == null)
            {
                var user = new Worker
                {
                    UserName = "kovacs@kevin.com",
                    Email = "kovacs@kevin.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Kovács Kevin",
                    Age = 22,
                    DriversLicence = false,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

            if (await userManager.FindByNameAsync("vas@bence.com") == null)
            {
                var user = new Worker
                {
                    UserName = "vas@bence.com",
                    Email = "vas@bence.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Vas Bence",
                    Age = 23,
                    DriversLicence = true,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

            if (await userManager.FindByNameAsync("szeki@szeki.com") == null)
            {
                var user = new Worker
                {
                    UserName = "szeki@szeki.com",
                    Email = "szeki@szeki.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Szekszárdi Szeki Gábor",
                    Age = 38,
                    DriversLicence = true,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

            if (await userManager.FindByNameAsync("kophazi@norbert.com") == null)
            {
                var user = new Worker
                {
                    UserName = "kophazi@norbert.com",
                    Email = "kophazi@norbert.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Kopházi Norbert",
                    Age = 19,
                    DriversLicence = true,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }


            if (await userManager.FindByNameAsync("csepin@zsombor.com") == null)
            {
                var user = new Worker
                {
                    UserName = "csepin@zsombor.com",
                    Email = "csepin@zsombor.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Csepin Zsombor",
                    Age = 19,
                    DriversLicence = false,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

            if (await userManager.FindByNameAsync("nagy@balazs.com") == null)
            {
                var user = new Worker
                {
                    UserName = "nagy@balazs.com",
                    Email = "nagy@balazs.com",
                    PhoneNumber = GeneratePhoneNumber(),
                    Name = "Nagy Balázs",
                    Age = 19,
                    DriversLicence = false,
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                    await userManager.AddPasswordAsync(user, password);
            }

        }
    }
}