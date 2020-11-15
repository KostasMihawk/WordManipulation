using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Xceed.Document.NET;
using WordManipulation.Interfaces;
using WordManipulation.Models;
using WordManipulation.ViewModels;

namespace WordManipulation.BML
{
    public class Agent
    {
        public Form TranslateFormVm(CreateVM vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            var form = new Form();
            form.DocumentType = new DocumentType();
            form.Place = vm.Place;
            form.Zone = generator.GetZones().SingleOrDefault(a => a.Id == vm.Zone);
            form.Attorneys = generator.GetAttorneysList().SingleOrDefault(a => a.Id == vm.Attorney);
            form.Bailif = generator.GetBaillifs().SingleOrDefault(b => b.Id == vm.Baillif);
            form.SelectTime = vm.SelectTime;
            form.Attacker = generator.GetAttackers().SingleOrDefault(a => a.Id == vm.Attacker);
            form.Defender = generator.GetDefenders().SingleOrDefault(d => d.Id == vm.Defender);
            form.DocumentType.DocumentNumber = vm.DocumentNumber;
            form.DocumentType.Court = vm.Court;
            form.DocumentType.HmeromhniaExodikou = vm.HmeromhniaExodikou;
            form.DocumentT = vm.DocumentEnum;
            form.Praxh = vm.Praxh;
            form.DocumentType.Hmeromhnia = vm.Hmeromhnia;
            form.DocumentType.Pinakio = vm.Pinakio;
            form.DocumentType.Dikasimos = vm.Dikasimos;
            form.DocumentType.Room = vm.Room;
            form.DocumentType.Tmhma = vm.Tmhma;
            form.DocumentType.GenikosArithmosKatathesis = vm.GenikosArithmos;
            form.DocumentType.EidikosArithmosKatathesis = vm.EidikosArithmos;
            form.DocumentType.Sumbolaiografos = vm.Sumbolaiografos;
            form.DocumentType.Ofeileths = vm.Ofeileths;
            return form;
        }

        public void ManageText(Form form, DocumentT documentType)
        {
            switch (documentType)
            {
                case DocumentT.Apofasi:
                    form.DocumentType.Name = "απόφασης";
                    form.DocumentType.Noun = "της";
                    form.DocumentType.EpikiromenoAdigrafo = "ακριβές επικυρωμένο αντίγραφο";
                    break;
                case DocumentT.ApofasiMeEpitagi:
                    form.DocumentType.Name = "απόφασης";
                    form.DocumentType.Noun = "της";
                    form.DocumentType.EpikiromenoAdigrafo = "ακριβές επικυρωμένο αντίγραφο";
                    form.DocumentType.EpilogosApofasis = "με την κάτω από αυτό παραγγελία προς επίδοση με επιταγή, το περιεχόμενο της οποίας έχει όπως ακριβώς στην παρούσα αντιγράφεται,";
                    break;
                case DocumentT.Exodiko:
                    form.DocumentType.Noun = "την";
                    form.DocumentType.HmeromhniaExodikou = form.DocumentType.HmeromhniaExodikou;
                    form.DocumentType.Name = "ΕΞΩΔΙΚΗ-ΔΗΛΩΣΗ-ΔΙΑΜΑΡΤΥΡΙΑ του πρώτου κατά αυτής";
                    form.DocumentType.EpilogosApofasis = "με την κάτω από αυτό παραγγελία προς επίδοση με επιταγή, το περιεχόμενο της οποίας έχει όπως ακριβώς στην παρούσα αντιγράφεται,";
                    break;
                case DocumentT.AgoghEparxias:
                    form.DocumentType.EpikiromenoAdigrafo = "ακριβές επικυρωμένο αντίγραφο";
                    break;
                case DocumentT.AgogiAthinas:
                    form.DocumentType.EpikiromenoAdigrafo = "ακριβές επικυρωμένο αντίγραφο";
                    break;
                case DocumentT.AnakopiAthinas:
                    form.DocumentType.EpikiromenoAdigrafo = "ακριβές επικυρωμένο αντίγραφο";
                    break;
                case DocumentT.AnakopiEparxeias:
                    form.DocumentType.EpikiromenoAdigrafo = "ακριβές επικυρωμένο αντίγραφο";
                    break;
                case DocumentT.AitisiAnastoliSAthina:
                    form.DocumentType.EpikiromenoAdigrafo = "ακριβές επικυρωμένο αντίγραφο";
                    break;
                case DocumentT.AitisiAnastolisEparxeia:
                    form.DocumentType.EpikiromenoAdigrafo = "ακριβές επικυρωμένο αντίγραφο";
                    break;
                case DocumentT.DilwshSunexisisPlirstiasmou:
                    form.DocumentType.EpikiromenoAdigrafo = "ακριβές επικυρωμένο αντίγραφο";
                    break;
                default:
                    break;

            }
        }

        public string CalculateDateForAgogiEparxeias(string date)
        {
            ITranslator translator = new Translator();
            DateTime realDate = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            return translator.TranslateDayOfMonth(realDate.Day) + " (" + realDate.Day +") του μηνός " +translator.ConvertMonth(realDate.Month) +" " +
                   "του έτους " +realDate.Year;
        }

        public void BoldText(Paragraph paragraph,string fontFamily,double fontSize, string text)
        {
            var parts = text.Split('@');
            for (int i = 0; i < parts.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    paragraph.Append(parts[i]).FontSize(fontSize).Font(fontFamily).Bold();
                }
                else
                {
                    paragraph.Append(parts[i]).FontSize(fontSize).Font(fontFamily);
                }
            }
        }

        public Form AutoCreateToForm(AutoCreate ac)
        {
            var form = new Form();

            return form;
        }
    }
}