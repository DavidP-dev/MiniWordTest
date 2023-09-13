using MiniSoftware;

var destinationPath = @"Fotodokumentace.docx";
var templatePath = @"Test.docx";
var photoPath = @"Foto č. 2.jpg";

var value = new Dictionary<string, object>()
{
    ["image"] = new MiniWordPicture() { Path = photoPath, Height = 360 }
};
        
MiniWord.SaveAsByTemplate(destinationPath, templatePath, value);