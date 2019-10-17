using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;


namespace TravelAgency
{
    public class CreatePDF
    {
       
        public CreatePDF(string contractID, string touristGuideName, string touristGuidePhone, string touristGuideEmail, string clientName,
            string clientJMBG, string clientPassport, string clientAge, string clientPhone, string clientEmail, string country, string city, string days,
            string room, string meals, string dateDeparture, string dateReturn, string hotelName, string hotelAddress, string hotelContact,
            string numOfPassengers, string fullPrice, string discount, string sumPrice, string paidNow, string leftToPay, string numOfPayments,
            string priceEachPayment, string dateFirstPayment, string dateLastPayment)
        {
            //Calculate paid now
            if(paidNow == "0")
            {
                paidNow = "/";
            } else
            {
                paidNow = paidNow + " €";
            }

            //Calculate discount
            if(discount == "0")
            {
                discount = "/";
            } else
            {
                discount = discount+ " €";
            }

            //If leftToPay is zero
            if(leftToPay == "0" || leftToPay == "0.0" || leftToPay == "0.00")
            {
                leftToPay = "/";
                numOfPayments = "/";
                priceEachPayment = "/";
                dateFirstPayment = "/";
                dateLastPayment = "/";
            } else
            {
                leftToPay = leftToPay+ " €";
                priceEachPayment = priceEachPayment + " €";
            }

            //Create directory for contracts, if doesn't exists
            string path = @"c:\Users\"+Environment.UserName+@"\Documents\Travel Agency\Contracts\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //Create Document
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path + contractID + ".pdf", FileMode.Create));

            try
            {
                doc.Open();

                //Start Header
                PdfPTable tableHeader = new PdfPTable(2);
                tableHeader.TotalWidth = 600f;
                tableHeader.SetTotalWidth(new float[] { 1f, 2f });
                tableHeader.SpacingAfter = 10f;

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance("logo.png");
                tableHeader.AddCell(image);

                Font fontHeader = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 16);
                PdfPCell cell = new PdfPCell(new Phrase("Contract number: "+ contractID, fontHeader));
                cell.HorizontalAlignment = 1;
                cell.VerticalAlignment = Element.ALIGN_BOTTOM;
                cell.PaddingBottom = 15f;
                tableHeader.AddCell(cell);
                doc.Add(tableHeader);
                //End Header

                //Start Subheader
                PdfPTable tableSubheader = new PdfPTable(6);
                tableSubheader.SetTotalWidth(new float[] { 1.5f, 2.5f, 1f, 2f, 1f, 2f });
                tableSubheader.SpacingAfter = 30f;
                addCellTitle("Agency", tableSubheader);
                addCellTitle("Tourist guide", tableSubheader);
                addCellTitle("Client", tableSubheader);

                addCellSubtitle("Name:\nAddress:\nCity:\nPIB:\nTel:\nFax:\nEmail:\nBank account:\nLicence:", tableSubheader);
                addCellText("CompanyName DOO\nMarka Oreskovica 16\nSubotica\n100841749\n+381(24)600-660\n+381(24)600-666\ninfo@companyname.com\n205000003145\nOTP 178/2010 from 09.02.2010", tableSubheader);
                addCellSubtitle("Name:\nTel:\nEmail:", tableSubheader);
                addCellText(touristGuideName + "\n"+ touristGuidePhone + "\n"+ touristGuideEmail, tableSubheader);
                addCellSubtitle("Name:\nTel:\nEmail:", tableSubheader);
                addCellText(clientName+"\n" + clientPhone+ "\n" + clientEmail, tableSubheader);

                doc.Add(tableSubheader);
                //End Subheader

                //Start Passengers
                PdfPTable tablePassengers = new PdfPTable(6);
                tablePassengers.SetTotalWidth(new float[] {1f, 1f, 1f, 0.5f, 1f, 1f });
                tablePassengers.SpacingAfter = 10f;
                Font fontTitlePassengers = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.BOLD);
                PdfPCell cellTitlePassengers = new PdfPCell(new Phrase("Passenger information\n\n", fontTitlePassengers));
                cellTitlePassengers.Colspan = 7;
                cellTitlePassengers.Border = Rectangle.TOP_BORDER | Rectangle.RIGHT_BORDER | Rectangle.LEFT_BORDER;
                tablePassengers.AddCell(cellTitlePassengers);

                addCellSubtitlePassengers("Name", tablePassengers);
                addCellSubtitlePassengers("JMBG", tablePassengers);
                addCellSubtitlePassengers("Passport", tablePassengers);
                addCellSubtitlePassengers("Age", tablePassengers);
                addCellSubtitlePassengers("Email", tablePassengers);
                addCellSubtitlePassengers("Phone", tablePassengers);

                addCellTextWithBorders(clientName, tablePassengers);
                addCellTextWithBorders(clientJMBG, tablePassengers);
                addCellTextWithBorders(clientPassport, tablePassengers);
                addCellTextWithBorders(clientAge, tablePassengers);
                addCellTextWithBorders(clientEmail, tablePassengers);
                addCellTextWithBorders(clientPhone, tablePassengers);

                doc.Add(tablePassengers);
                //End Passengers

                //Start Offer
                PdfPTable tableOffer = new PdfPTable(4);
                tableOffer.SetTotalWidth(new float[] { 1.5f, 3f, 2f, 1.5f });
                tableOffer.SpacingAfter = 10f;
                addCellTitleOffer("Contract information\n\n", tableOffer);

                addCellSubtitle("Country:\nCity:\nDays:\nRoom:\nMeals:\nDate departure:\nDate return:\nHotel:\nHotel address:\nHotel contact:", tableOffer);
                addCellText(country+"\n"+city+"\n"+days+"\n"+room+"\n"+meals+"\n"+dateDeparture+"\n"+dateReturn+"\n"+hotelName+"\n"+hotelAddress+"\n"+hotelContact, tableOffer);
                addCellSubtitle("Number of passengers:\nFull price:\nDiscount:\nSum price:\nPaid now:\nPrice left to pay:\nNumber of payments:\nPrice of each payment:\nDate first payment:\nDate last payment:", tableOffer);
                addCellText(numOfPassengers+"\n"+ fullPrice+ " €\n" + discount+ "\n" +sumPrice+ " €\n" + paidNow + "\n" + leftToPay+ "\n" + numOfPayments + "\n"+ priceEachPayment + "\n" + dateFirstPayment + "\n"+ dateLastPayment, tableOffer);

                doc.Add(tableOffer);
                //End offer

                //Start Law
                PdfPTable tableLaw = new PdfPTable(1);
                tableLaw.SpacingAfter = 50f;
                addCellTextWithBorders("The General Conditions of Travel that apply to this agreement are according to Travel Organizer terms and conditions " +
                    "(document No.121258) Contact person for claims for Company Name is Marko Markovic, contact phone: +381 24 600 660, e - mail address: " +
                    "info@companyname.rs Payment in EUR only.With your signature you confirm that you are aware of the general terms and conditions of travel, " +
                    "travel guarantee and travel program of the Organizer, that you are informed of the travel conditions insurance and travel cancellation " +
                    "insurance, and that you agree to it on your own behalf and on behalf of companions.", tableLaw);
                doc.Add(tableLaw);
                //End Law

                //Start Signatures
                PdfPTable tableSignatures = new PdfPTable(2);
                tableSignatures.SetTotalWidth(new float[] { 2f, 1f });
                addCellTextSignature("In Subotica, "+ DateTime.Now.ToString("dd.MM.yyyy") + "\n\n\nClient\n\n"+clientName+"\n\n\n_________________________", tableSignatures);
                addCellTextSignature("\n\n\nFor CompanyName DOO\n\n"+User.Username+"\n\n\n_________________________", tableSignatures);

                doc.Add(tableSignatures);
                //End Signatures
            }
            finally
            {
                doc.Close();
            }
            
        }

        private void addCellTitle(string text, PdfPTable table)
        {
            Font font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.BOLD);
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Colspan = 2;
            cell.HorizontalAlignment = 0;
            cell.Border = Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.PaddingBottom = 5f;
            table.AddCell(cell);
        }

        private void addCellSubtitle(string text, PdfPTable table)
        {
            Font font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, Font.BOLD);
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = 0;
            cell.Border = Rectangle.LEFT_BORDER | Rectangle.BOTTOM_BORDER;
            cell.PaddingBottom = 5f;
            table.AddCell(cell);
        }

        private void addCellText(string text, PdfPTable table)
        {
            Font font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10);
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Border = Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER;
            cell.HorizontalAlignment = 0;
            cell.PaddingBottom = 5f;
            table.AddCell(cell);
        }

        private void addCellSubtitlePassengers(string text, PdfPTable table)
        {
            Font font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, Font.BOLD);
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = 1;
            cell.PaddingBottom = 5f;
            table.AddCell(cell);
        }

        private void addCellTextWithBorders(string text, PdfPTable table)
        {
            Font font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10);
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = 0;
            cell.PaddingBottom = 5f;
            table.AddCell(cell);
        }

        private void addCellTitleOffer(string text, PdfPTable table)
        {
            Font font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.BOLD);
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Colspan = 4;
            cell.HorizontalAlignment = 0;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.PaddingBottom = 5f;
            table.AddCell(cell);
        }

        private void addCellTextSignature(string text, PdfPTable table)
        {
            Font font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10);
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Border = Rectangle.NO_BORDER;
            cell.HorizontalAlignment = 0;
            cell.PaddingBottom = 5f;
            table.AddCell(cell);
        }
    }
}
