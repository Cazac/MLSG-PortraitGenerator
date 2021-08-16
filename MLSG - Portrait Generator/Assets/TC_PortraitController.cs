using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


///////////////
/// <summary>
///     
/// TC_PortraitController is used to generate Portraits and load them
/// 
/// 1. Canvas
/// 1. Clothes
/// 2. Ears
/// 3. Face
/// 4. Eyes
/// 5. Mouth
/// 6. Nose
/// 7. Skin Tone
/// 8. Eyebrows
/// 9. Top Hair
/// 10. Facial Har
/// 11. Hats
/// 
/// </summary>
///////////////

public class TC_PortraitController : MonoBehaviour
{
    ////////////////////////////////

    [Header("Single Image")]
    public Image portraitViewer;
    public Image portraitViewer_BG;

    ////////////////////////////////

    [Header("Multi Image")]
    public Image portraitGen_Canvas;
    public Image portraitGen_Face;
    public Image portraitGen_ScarMain;
    public Image portraitGen_ScarSecond;
    public Image portraitGen_ScarThird;
    public Image portraitGen_Eyes;
    public Image portraitGen_Eyebrows;
    public Image portraitGen_Nose;
    public Image portraitGen_Mouth;
    public Image portraitGen_Ears;
    public Image portraitGen_HairTop;
    public Image portraitGen_HairFacial;
    public Image portraitGen_Clothes;
    public Image portraitGen_Hat;

    ////////////////////////////////

    [Header("Canvas Module")]
    public List<Sprite> canvasModules_All_List;

    ////////////////////////////////

    [Header("Face Modules")]
    public List<Sprite> FaceModules_All_List;

    [Header("Skin Tones Modules")]
    public List<Color32> SkinToneModules_Roman_List;
    public List<Color32> SkinToneModules_Greek_List;
    public List<Color32> SkinToneModules_Persian_List;

    ////////////////////////////////

    [Header("Eye Modules")]
    public List<Sprite> EyesModules_All_List;
   
    [Header("Eyebrow Modules")]
    public List<Sprite> EyebrowsModules_All_List;

    [Header("Nose Modules")]
    public List<Sprite> NoseModules_All_List;

    [Header("Mouth Modules")]
    public List<Sprite> MouthModules_All_List;

    [Header("Ears Modules")]
    public List<Sprite> EarsModules_All_List;

    [Header("Scar Modules")]
    public List<Sprite> ScarsModules_All_List;

    ////////////////////////////////

    [Header("Hair Top Modules")]
    public List<Sprite> HairTopBlackModules_All_List;
    public List<Sprite> HairTopChestnutModules_All_List;
    public List<Sprite> HairTopBrownModules_All_List;
    public List<Sprite> HairTopWhiteModules_All_List;

    [Header("Hair Facial Modules")]
    public List<Sprite> HairFacialBlackModules_All_List;
    public List<Sprite> HairFacialChestnutModules_All_List;
    public List<Sprite> HairFacialBrownModules_All_List;
    public List<Sprite> HairFacialWhiteModules_All_List;

    ////////////////////////////////

    [Header("Clothes Modules")]
    public List<Sprite> ClothesModules_Greek_List;
    public List<Sprite> ClothesModules_Roman_List;
    public List<Sprite> ClothesModules_Persian_List;

    [Header("Hats Modules")]
    public List<Sprite> HatsModules_Greek_List;
    public List<Sprite> HatsModules_Roman_List;
    public List<Sprite> HatsModules_Persian_List;

    /////////////////////////////////////////////////////////////////

    public void Button_RandomPortrait_Single()
    {
        //Single
        GeneratePortrait_SingleImage();
    }

    public void Button_RandomPortrait_Multi_Roman()
    {
        //Multi Roman
        GeneratePortrait_MultiImage_Roman();
    }

    public void Button_RandomPortrait_Multi_Greek()
    {
        //Multi Greek
        GeneratePortrait_MultiImage_Greek();
    }

    public void Button_RandomPortrait_Multi_Persian()
    {
        //Multi Persian
        GeneratePortrait_MultiImage_Persian();
    }

    /////////////////////////////////////////////////////////////////

    private void GeneratePortrait_SingleImage()
    {
        //Reset Ordered List
        List<Texture2D> orderedModules_List = new List<Texture2D>();

        //Get Base Modules
        Texture2D fullPortrait = canvasModules_All_List[Random.Range(0, canvasModules_All_List.Count)].texture;




        //Clothes
        if (ClothesModules_Roman_List.Count != 0)
        {
            Texture2D clothes = ClothesModules_Roman_List[Random.Range(0, ClothesModules_Roman_List.Count)].texture;
            orderedModules_List.Add(clothes);
        }

        //Ears
        if (EarsModules_All_List.Count != 0)
        {
            Texture2D ears = EarsModules_All_List[Random.Range(0, EarsModules_All_List.Count)].texture;
            orderedModules_List.Add(ears);
        }

        //Faces
        if (FaceModules_All_List.Count != 0)
        {
            Texture2D face = FaceModules_All_List[Random.Range(0, FaceModules_All_List.Count)].texture;
            orderedModules_List.Add(face);
        }

        //Eyes
        if (EyesModules_All_List.Count != 0)
        {
            Texture2D eyes = EyesModules_All_List[Random.Range(0, EyesModules_All_List.Count)].texture;
            orderedModules_List.Add(eyes);
        }

        //Eyebrows
        if (EyebrowsModules_All_List.Count != 0)
        {
            Texture2D eyebrows = EyebrowsModules_All_List[Random.Range(0, EyebrowsModules_All_List.Count)].texture;
            orderedModules_List.Add(eyebrows);
        }

        //Mouth
        if (MouthModules_All_List.Count != 0)
        {
            Texture2D mouth = MouthModules_All_List[Random.Range(0, MouthModules_All_List.Count)].texture;
            orderedModules_List.Add(mouth);
        }

        //Nose
        if (NoseModules_All_List.Count != 0)
        {
            Texture2D nose = NoseModules_All_List[Random.Range(0, NoseModules_All_List.Count)].texture;
            orderedModules_List.Add(nose);
        }

        //HairTop
        if (HairTopBlackModules_All_List.Count != 0)
        {
            Texture2D hairTop = HairTopBlackModules_All_List[Random.Range(0, HairTopBlackModules_All_List.Count)].texture;
            orderedModules_List.Add(hairTop);
        }

        //HairFacial
        if (HairFacialChestnutModules_All_List.Count != 0)
        {
            Texture2D hairFacial = HairFacialChestnutModules_All_List[Random.Range(0, HairFacialChestnutModules_All_List.Count)].texture;
            orderedModules_List.Add(hairFacial);
        }

        //Hats





        //Reset Counter
        int counter = 0;

        //Loop All Modules
        foreach (Texture2D nextModule in orderedModules_List)
        {
            //Merge Each Image
            fullPortrait = MergeImages(fullPortrait, orderedModules_List[counter]);
            counter++;
        }

        //Randomize Debug Spawn Name
        int randomNameNumber = Random.Range(0, 100);


        //Convert Bytes To PNG
        byte[] newPNGBytes = ImageConversion.EncodeToPNG(fullPortrait);

        //Get file path for PNG
        string filePath_PNG = "Assets/Resources/PFP " + randomNameNumber + ".png";

        //Write PNG To Disk
        File.WriteAllBytes(filePath_PNG, newPNGBytes);
   
        //Convert Texture To Sprite
        Sprite fullPortrait_Sprite = Sprite.Create(fullPortrait, new Rect(0.0f, 0.0f, fullPortrait.width, fullPortrait.height), new Vector2(0.5f, 0.5f), 100.0f);

        //Set sprite viewing
        portraitViewer.sprite = fullPortrait_Sprite;
    }

    private void GeneratePortrait_MultiImage_Roman()
    {
        //Create New Commander
        DebugCommander commander = new DebugCommander();

        ////////////////////////////////

        //Color Background By Faction
        GenerateBackground_Roman(commander);

        //Color Skin Tone
        GenerateSkinTone_Roman(commander);

        //Create Charecter
        GenerateCharecter_Roman(commander);

        //Add Strething Randomization
        GenerateStretching_Roman(commander);

        ////////////////////////////////

        //Load Commander To Screen
        LoadCommanderPicture(commander);
    }

    private void GeneratePortrait_MultiImage_Greek()
    {
        //Create New Commander
        DebugCommander commander = new DebugCommander();

        ////////////////////////////////

        //Color Background By Faction
        GenerateBackground_Roman(commander);

        //Color Skin Tone
        GenerateSkinTone_Roman(commander);

        //Create Charecter
        GenerateCharecter_Roman(commander);

        //Add Strething Randomization
        GenerateStretching_Roman(commander);

        ////////////////////////////////

        //Load Commander To Screen
        LoadCommanderPicture(commander);
    }

    private void GeneratePortrait_MultiImage_Persian()
    {
        //Create New Commander
        DebugCommander commander = new DebugCommander();

        ////////////////////////////////

        //Color Background By Faction
        GenerateBackground_Roman(commander);

        //Color Skin Tone
        GenerateSkinTone_Roman(commander);

        //Create Charecter
        GenerateCharecter_Roman(commander);

        //Add Strething Randomization
        GenerateStretching_Roman(commander);

        ////////////////////////////////

        //Load Commander To Screen
        LoadCommanderPicture(commander);
    }

    /////////////////////////////////////////////////////////////////

    

    /////////////////////////////////////////////////////////////////

    private void GenerateCharecter_Roman(DebugCommander commander)
    {
        //Faces
        commander.pfpImage_Face = Random.Range(0, FaceModules_All_List.Count);

        //Scars
        commander.pfpImage_ScarMain = Random.Range(0, ScarsModules_All_List.Count);
        //commander.pfpImage_ScarMain = Random.Range(0, ScarsModules_All_List.Count);
        //commander.pfpImage_ScarMain = Random.Range(0, ScarsModules_All_List.Count);

        //Ears
        commander.pfpImage_Ears = Random.Range(0, EarsModules_All_List.Count);

        //Nose
        commander.pfpImage_Nose = Random.Range(0, NoseModules_All_List.Count);

        //Mouth
        commander.pfpImage_Mouth = Random.Range(0, MouthModules_All_List.Count);

        //Eyes
        commander.pfpImage_Eyes = Random.Range(0, EyesModules_All_List.Count);

        //Eyebrows
        commander.pfpImage_Eyebrows = Random.Range(0, EyebrowsModules_All_List.Count);

        //Clothes
        commander.pfpImage_Clothes = Random.Range(0, ClothesModules_Roman_List.Count);

        //Hair Color
        commander.pfpImage_HairColor = Random.Range(0, 4);

        //Hair
        if (commander.pfpImage_HairColor == 0)
        {
            //Black Hair
            commander.pfpImage_TopHair = Random.Range(0, HairTopBlackModules_All_List.Count);
            commander.pfpImage_FacialHair = Random.Range(0, HairFacialBlackModules_All_List.Count);
        }
        else if (commander.pfpImage_HairColor == 1)
        {
            //Chestnut Hair
            commander.pfpImage_TopHair = Random.Range(0, HairTopChestnutModules_All_List.Count);
            commander.pfpImage_FacialHair = Random.Range(0, HairFacialChestnutModules_All_List.Count);
        }
        else if (commander.pfpImage_HairColor == 2)
        {
            //Brown Hair
            commander.pfpImage_TopHair = Random.Range(0, HairTopBrownModules_All_List.Count);
            commander.pfpImage_FacialHair = Random.Range(0, HairFacialBrownModules_All_List.Count);
        }
        else if (commander.pfpImage_HairColor == 3)
        {
            //White Hair
            commander.pfpImage_TopHair = Random.Range(0, HairTopWhiteModules_All_List.Count);
            commander.pfpImage_FacialHair = Random.Range(0, HairFacialWhiteModules_All_List.Count);
        }

        //Hat
        commander.pfpImage_Hat = Random.Range(0, HatsModules_Roman_List.Count);

        if (commander.pfpImage_Hat == 0 || commander.pfpImage_Hat == 1)
        {
            commander.pfpImage_TopHair = 0;
            commander.pfpImage_Ears = 0;
        }
    }

    private void GenerateSkinTone_Roman(DebugCommander commander)
    {
        //Skin Tones
        commander.pfpImage_SkinTone = SkinToneModules_Roman_List[Random.Range(0, SkinToneModules_Roman_List.Count)];
    }

    private void GenerateBackground_Roman(DebugCommander commander)
    {
        //Hue
        int redDebug = Random.Range(0, 2);
        float HSV_Hue = 0;

        if (redDebug == 0)
        {
            HSV_Hue = Random.Range(0f, 11f) / 360;
        }
        else
        {
            HSV_Hue = Random.Range(350f, 361f) / 360;
        }

        //Sat / Value
        float HSV_Sat = Random.Range(60f, 101f) / 100;
        float HSV_Value = Random.Range(60f, 101f) / 100;


        //Set Values Multi
        commander.pfpImage_Canvas = Random.Range(0, canvasModules_All_List.Count);
        commander.pfpImage_CanvasColor = Color.HSVToRGB(HSV_Hue, HSV_Sat, HSV_Value);

        //Set Color Single
        portraitViewer_BG.sprite = canvasModules_All_List[Random.Range(0, canvasModules_All_List.Count)];
        portraitViewer_BG.color = Color.HSVToRGB(HSV_Hue, HSV_Sat, HSV_Value);
    }

    private void GenerateStretching_Roman(DebugCommander commander)
    {

        //int widthSize = Random.Range(440, 500);
        //int heightSize = Random.Range(440, 500);

        //if ()
        {

        }


        //Default 460 460

        
        commander.pfpImage_Width = Random.Range(400, 470);
        commander.pfpImage_Height = Random.Range(420, 490);
    }

    /////////////////////////////////////////////////////////////////

    private void LoadCommanderPicture(DebugCommander commander)
    {
        //Canvas
        portraitGen_Canvas.sprite = canvasModules_All_List[commander.pfpImage_Canvas];
        portraitGen_Canvas.color = commander.pfpImage_CanvasColor;

        //Face
        portraitGen_Face.sprite = FaceModules_All_List[commander.pfpImage_Face];
        portraitGen_ScarMain.sprite = ScarsModules_All_List[commander.pfpImage_ScarMain];
        portraitGen_Ears.sprite = EarsModules_All_List[commander.pfpImage_Ears];
        portraitGen_Nose.sprite = NoseModules_All_List[commander.pfpImage_Nose];
        portraitGen_Mouth.sprite = MouthModules_All_List[commander.pfpImage_Mouth];
        portraitGen_Eyebrows.sprite = EyebrowsModules_All_List[commander.pfpImage_Eyebrows];
        portraitGen_Eyes.sprite = EyesModules_All_List[commander.pfpImage_Eyes];

        //Skin Color
        portraitGen_Face.color = commander.pfpImage_SkinTone;
        portraitGen_ScarMain.color = commander.pfpImage_SkinTone;
        portraitGen_Ears.color = commander.pfpImage_SkinTone;
        portraitGen_Nose.color = commander.pfpImage_SkinTone;
        portraitGen_Mouth.color = commander.pfpImage_SkinTone;

        //Hair
        if (commander.pfpImage_HairColor == 0)
        {
            //Black Hair
            portraitGen_HairTop.sprite = HairTopBlackModules_All_List[commander.pfpImage_TopHair];
            portraitGen_HairFacial.sprite = HairFacialBlackModules_All_List[commander.pfpImage_FacialHair];
        }
        else if (commander.pfpImage_HairColor == 1)
        {
            //Chestnut Hair
            portraitGen_HairTop.sprite = HairTopChestnutModules_All_List[commander.pfpImage_TopHair];
            portraitGen_HairFacial.sprite = HairFacialChestnutModules_All_List[commander.pfpImage_FacialHair];
        }
        else if (commander.pfpImage_HairColor == 2)
        {
            //Brown Hair
            portraitGen_HairTop.sprite = HairTopBrownModules_All_List[commander.pfpImage_TopHair];
            portraitGen_HairFacial.sprite = HairFacialBrownModules_All_List[commander.pfpImage_FacialHair];
        }
        else if (commander.pfpImage_HairColor == 3)
        {
            //White Hair
            portraitGen_HairTop.sprite = HairTopWhiteModules_All_List[commander.pfpImage_TopHair];
            portraitGen_HairFacial.sprite = HairFacialWhiteModules_All_List[commander.pfpImage_FacialHair];
        }

        //Clothes
        portraitGen_Clothes.sprite = ClothesModules_Roman_List[commander.pfpImage_Clothes];
        portraitGen_Hat.sprite = HatsModules_Roman_List[commander.pfpImage_Hat];

        //Stretching
        Vector2 stretchValue = new Vector2(commander.pfpImage_Width, commander.pfpImage_Height);
        portraitGen_Face.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
        portraitGen_ScarMain.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
        portraitGen_Eyes.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
        portraitGen_Eyebrows.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
        portraitGen_Nose.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
        portraitGen_Mouth.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
        portraitGen_Ears.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
        portraitGen_HairTop.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
        portraitGen_HairFacial.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
        portraitGen_Hat.gameObject.GetComponent<RectTransform>().sizeDelta = stretchValue;
    }

    /////////////////////////////////////////////////////////////////






    /////////////////////////////////////////////////////////////////

    private Texture2D MergeImages(Texture2D bottom, Texture2D top)
    {
        //Check If Valid Images Were Loaded
        if (bottom.width != top.width || bottom.height != top.height)
        {
            throw new System.InvalidOperationException("AlphaBlend only works with two equal sized images");
        }

        //Get Pixel Colors / Data
        var bData = bottom.GetPixels();
        var tData = top.GetPixels();
        int count = bData.Length;
        var rData = new Color[count];

        //Merge All Pixels
        for (int i = 0; i < count; i++)
        {
            Color B = bData[i];
            Color T = tData[i];
            float srcF = T.a;
            float destF = 1f - T.a;
            float alpha = srcF + destF * B.a;
            Color R = (T * srcF + B * B.a * destF) / alpha;
            R.a = alpha;
            rData[i] = R;
        }

        //Create New Image With Merged Pixels
        bottom = new Texture2D(top.width, top.height);
        bottom.SetPixels(rData);
        bottom.Apply();

        return bottom;
    }

    private void StretchImage()
    {
        /*
        Image myImage1 = new Image();

        // Set the stretch property.
        myImage1.Stretch = Stretch.Fill;

        // Set the StretchDirection property.
        myImage1.StretchDirection = StretchDirection.Both;

        // Create source
        BitmapImage myBitmapImage1 = new BitmapImage();

        // BitmapImage.UriSource must be in a BeginInit/EndInit block
        myBitmapImage1.BeginInit();
        myBitmapImage1.UriSource = new Uri(@"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Winter.jpg");
        myBitmapImage1.EndInit();

        //set image source
        myImage1.Source = myBitmapImage1;
        */
    }

    /////////////////////////////////////////////////////////////////
}






/////////////////////////////////////////////////////////////////

public class DebugCommander 
{
    //Canvas
    public int pfpImage_Canvas;
    public Color pfpImage_CanvasColor;

    //Skin Tone
    public Color pfpImage_SkinTone;

    public int pfpImage_HairColor;

    //Charecter
    public int pfpImage_Eyes;
    public int pfpImage_Clothes;
    public int pfpImage_Ears;
    public int pfpImage_Face;
    public int pfpImage_Nose;
    public int pfpImage_Eyebrows;
    public int pfpImage_Hat;
    public int pfpImage_TopHair;
    public int pfpImage_FacialHair;
    public int pfpImage_Mouth;
    public int pfpImage_ScarMain;
    public int pfpImage_ScarSecond;
    public int pfpImage_ScarThird;

    //Streatch
    public int pfpImage_Width;
    public int pfpImage_Height;
}

/////////////////////////////////////////////////////////////////
