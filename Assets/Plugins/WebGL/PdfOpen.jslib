var PdfOpen = {
    OpenPdfByUrl:function(url)
    {
        window.open(Pointer_stringify(url),"_blank");
    }
	
};

mergeInto(LibraryManager.library, PdfOpen);