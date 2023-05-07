﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordManipulation.Models;
using WordManipulation.ViewModels;
using Xceed.Words.NET;

namespace WordManipulation.Interfaces
{
    interface IDocXManager
    {
        DocX CreatePricingAndNameTable(DocX doc, Zone zone, bool isFusikoProswpo, bool ZoneB);
        DocX AddHeaderToDocument(DocX doc, string fontFamilyCustom);
        DocX CreateIntroParagraph(DocX doc, string location, string locationUpiresias, bool isFusikoProsopo, string epispeudon, string DikigorosDesc);
        DocX EpispeudonParagraph(DocX doc, bool isFusikoProsopo, Gender gender, string ofeileths, string upiresia);
        DocX ParagraphAkrivesAdigrafo(DocX doc, Gender gender, string documentNumber, string sumbolaiografos, string ofeileths, bool Article);
        DocX ParagrafosPraxis(DocX doc, bool? isPraxi, string keimenoPraxis);
        DocX ParagrafosSuntaxisEkthesis(DocX doc);
        DocX ParagrafosUpografis(DocX doc, bool? isPraxi, bool isFusikoProsopo, Signature signature);
        MemoryStream CreateAndReturnDocAsMemoryStream(DocX doc);
        MemoryStream EntoliSunexisisPlistiriasmou(SunexisiPlistiriasmouModel model);
        MemoryStream PraxiPlistiriasmou(LoanerInvitationModel model);
        MemoryStream Katasxetiria(KatasxetirioModel model);
        MemoryStream DilosiSunexisis(DilosiSunexisisModel model);


    }
}
