using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    public bool skinOne = false;
    public TMP_Text skinOneText;
    public bool skinTwo = false;
    public TMP_Text skinTwoText;
    public bool skinThree = false;
    public TMP_Text skinThreeText;
    public bool skinFour = false;
    public TMP_Text skinFourText;
    public bool skinFive = false;
    public TMP_Text skinFiveText;
    public bool skinSix = false;
    public TMP_Text skinSixText;
    public bool skinSeven = false;
    public TMP_Text skinSevenText;
    public bool skinEight = false;
    public TMP_Text skinEightText;
    public bool skinNine = false;
    public TMP_Text skinNineText;
    public bool skinTen = false;
    public TMP_Text skinTenText;
    public bool skinEleven = false;
    public TMP_Text skinElevenText;
    public bool skinTwelve = false;
    public TMP_Text skinTwelveText;
    public bool skinThirteen = false;
    public TMP_Text skinThirteenText;
    public bool skinFourteen = false;
    public TMP_Text skinFourteenText;
    public bool skinFifthteen = false;
    public TMP_Text skinFifthteenText;
    public bool skinSixteen = false;
    public TMP_Text skinSixteenText;
    public bool skinSeventeen = false;
    public TMP_Text skinSeventeenText;
    public bool skinEightteen = false;
    public TMP_Text skinEightteenText;
    public bool skinNineteen = false;
    public TMP_Text skinNineteenText;


    public int debug = 0;

    private int points;

    public void Skin_Zero()
    {
        {
            PlayerPrefs.SetInt("SkinPicked", 0);
        }        
    }

    public void Skin_One()
    {
        if (skinOne == false)
        {
            if (points >= 1000)
            {
                PlayerPrefs.SetInt("01_skin", 1);
                points = points - 1000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinOneText.text = "Mud";
                skinOne = true;
                PlayerPrefs.SetInt("SkinPicked", 1);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 1);
        }
    }

    public void Skin_Two()
    {
        if (skinTwo == false)
        {
            if (points >= 1000)
            {
                PlayerPrefs.SetInt("02_skin", 1);
                points = points - 1000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinTwoText.text = "Glass";
                skinTwo = true;
                PlayerPrefs.SetInt("SkinPicked", 2);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 2);
        }
    }

    public void Skin_Three()
    {
        if (skinThree == false)
        {
            if (points >= 1000)
            {
                PlayerPrefs.SetInt("03_skin", 1);
                points = points - 1000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinThreeText.text = "Grass";
                skinThree = true;
                PlayerPrefs.SetInt("SkinPicked", 3);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 3);
        }
    }

    public void Skin_Four()
    {
        if (skinFour == false)
        {
            if (points >= 1000)
            {
                PlayerPrefs.SetInt("04_skin", 1);
                points = points - 1000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinFourText.text = "Lava";
                skinFour = true;
                PlayerPrefs.SetInt("SkinPicked", 4);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 4);
        }
    }

    public void Skin_Five()
    {
        if (skinFive == false)
        {
            if (points >= 2000)
            {
                PlayerPrefs.SetInt("05_skin", 1);
                points = points - 2000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinFiveText.text = "Ying Bang";
                skinFive = true;
                PlayerPrefs.SetInt("SkinPicked", 5);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 5);
        }
    }

    public void Skin_Six()
    {
        if (skinSix == false)
        {
            if (points >= 2000)
            {
                PlayerPrefs.SetInt("06_skin", 1);
                points = points - 2000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinSixText.text = "Rainbow";
                skinSix = true;
                PlayerPrefs.SetInt("SkinPicked", 6);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 6);
        }
    }

    public void Skin_Seven()
    {
        if (skinSeven == false)
        {
            if (points >= 2000)
            {
                PlayerPrefs.SetInt("07_skin", 1);
                points = points - 2000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinSevenText.text = "Camo";
                skinSeven = true;
                PlayerPrefs.SetInt("SkinPicked", 7);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 7);
        }
    }

    public void Skin_Eight()
    {
        if (skinEight == false)
        {
            if (points >= 2000)
            {
                PlayerPrefs.SetInt("08_skin", 1);
                points = points - 2000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinEightText.text = "Void";
                skinEight = true;
                PlayerPrefs.SetInt("SkinPicked", 8);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 8);
        }
    }

    public void Skin_Nine()
    {
        if (skinNine == false)
        {
            if (points >= 2000)
            {
                PlayerPrefs.SetInt("09_skin", 1);
                points = points - 2000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinNineText.text = "Void";
                skinNine = true;
                PlayerPrefs.SetInt("SkinPicked", 9);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 9);
        }
    }

    public void Skin_Ten()
    {
        if (skinTen == false)
        {
            if (points >= 5000)
            {
                PlayerPrefs.SetInt("10_skin", 1);
                points = points - 2000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinTenText.text = "Basket";
                skinTen = true;
                PlayerPrefs.SetInt("SkinPicked", 10);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 10);
        }
    }

    public void Skin_Eleven()
    {
        if (skinEleven == false)
        {
            if (points >= 5000)
            {
                PlayerPrefs.SetInt("11_skin", 1);
                points = points - 5000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinElevenText.text = "Bubbles";
                skinEleven = true;
                PlayerPrefs.SetInt("SkinPicked", 11);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 11);
        }
    }

    public void Skin_Twelve()
    {
        if (skinTwelve == false)
        {
            if (points >= 5000)
            {
                PlayerPrefs.SetInt("12_skin", 1);
                points = points - 5000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinTwelveText.text = "JetBlack";
                skinTwelve = true;
                PlayerPrefs.SetInt("SkinPicked", 12);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 12);
        }
    }

    public void Skin_Thirteen()
    {
        if (skinThirteen == false)
        {
            if (points >= 5000)
            {
                PlayerPrefs.SetInt("13_skin", 1);
                points = points - 5000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinThirteenText.text = "Slime";
                skinThirteen = true;
                PlayerPrefs.SetInt("SkinPicked", 13);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 13);
        }
    }

    public void Skin_Fourteen()
    {
        if (skinFourteen == false)
        {
            if (points >= 5000)
            {
                PlayerPrefs.SetInt("14_skin", 1);
                points = points - 5000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinFourteenText.text = "Blue";
                skinFourteen = true;
                PlayerPrefs.SetInt("SkinPicked", 14);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 14);
        }
    }

    public void Skin_Fifthteen()
    {
        if (skinFifthteen == false)
        {
            if (points >= 10000)
            {
                PlayerPrefs.SetInt("15_skin", 1);
                points = points - 10000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinFifthteenText.text = "Steel";
                skinFifthteen = true;
                PlayerPrefs.SetInt("SkinPicked", 15);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 15);
        }
    }

    public void Skin_Sixteen()
    {
        if (skinSixteen == false)
        {
            if (points >= 20000)
            {
                PlayerPrefs.SetInt("16_skin", 1);
                points = points - 10000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinSixteenText.text = "Bronze";
                skinSixteen = true;
                PlayerPrefs.SetInt("SkinPicked", 16);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 16);
        }
    }

    public void Skin_Seventeen()
    {
        if (skinSeventeen == false)
        {
            if (points >= 20000)
            {
                PlayerPrefs.SetInt("17_skin", 1);
                points = points - 20000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinSeventeenText.text = "Silver";
                skinSeventeen = true;
                PlayerPrefs.SetInt("SkinPicked", 17);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 17);
        }
    }

    public void Skin_Eightteen()
    {
        if (skinEightteen == false)
        {
            if (points >= 20000)
            {
                PlayerPrefs.SetInt("18_skin", 1);
                points = points - 20000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinEightteenText.text = "Shaped Glass";
                skinEightteen = true;
                PlayerPrefs.SetInt("SkinPicked", 18);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 18);
        }
    }

    public void Skin_Nineteen()
    {
        if (skinNineteen == false)
        {
            if (points >= 100000)
            {
                PlayerPrefs.SetInt("19_skin", 1);
                points = points - 100000;
                PlayerPrefs.SetInt("Points", points);
                scoreText.text = "Points: " + points.ToString();
                skinNineteenText.text = "Gold";
                skinNineteen = true;
                PlayerPrefs.SetInt("SkinPicked", 19);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinPicked", 19);
        }
    }

    public void reset()
    {
        PlayerPrefs.SetInt("01_skin", 0);
        skinOneText.text = "1000";
        skinOne = false;
        PlayerPrefs.SetInt("02_skin", 0);
        skinTwoText.text = "1000";
        skinTwo = false;
        PlayerPrefs.SetInt("03_skin", 0);
        skinThreeText.text = "1000";
        skinThree = false;
        PlayerPrefs.SetInt("04_skin", 0);
        skinFourText.text = "1000";
        skinFour = false;
        PlayerPrefs.SetInt("05_skin", 0);
        skinFiveText.text = "2000";
        skinFive = false;
        PlayerPrefs.SetInt("06_skin", 0);
        skinSixText.text = "2000";
        skinSix = false;
        PlayerPrefs.SetInt("07_skin", 0);
        skinSevenText.text = "2000";
        skinSeven = false;
        PlayerPrefs.SetInt("08_skin", 0);
        skinEightText.text = "2000";
        skinEight = false;
        PlayerPrefs.SetInt("09_skin", 0);
        skinNineText.text = "2000";
        skinNine = false;
        PlayerPrefs.SetInt("10_skin", 0);
        skinTenText.text = "5000";
        skinTen = false;
        PlayerPrefs.SetInt("11_skin", 0);
        skinElevenText.text = "5000";
        skinEleven = false;
        PlayerPrefs.SetInt("12_skin", 0);
        skinTwelveText.text = "5000";
        skinTwelve = false;
        PlayerPrefs.SetInt("13_skin", 0);
        skinThirteenText.text = "5000";
        skinThirteen = false;
        PlayerPrefs.SetInt("14_skin", 0);
        skinFourteenText.text = "5000";
        skinFourteen = false;
        PlayerPrefs.SetInt("15_skin", 0);
        skinFifthteenText.text = "10000";
        skinFifthteen = false;
        PlayerPrefs.SetInt("16_skin", 0);
        skinSixteenText.text = "20000";
        skinSixteen = false;
        PlayerPrefs.SetInt("17_skin", 0);
        skinSeventeenText.text = "20000";
        skinSeventeen = false;
        PlayerPrefs.SetInt("18_skin", 0);
        skinEightteenText.text = "20000";
        skinEightteen = false;
        PlayerPrefs.SetInt("19_skin", 0);
        skinNineteenText.text = "100000";
        skinNineteen = false;
        PlayerPrefs.SetInt("SkinPicked", 0);
        points = debug;
        PlayerPrefs.SetInt("Points", points);
        
        scoreText.text = "Points: " + points.ToString();
    }

    void Start()
    {
        if (PlayerPrefs.GetInt("01_skin") == 1)
        {
            skinOne = true;
            skinOneText.text = "Mud";
        }
        if (PlayerPrefs.GetInt("02_skin") == 1)
        {
            skinTwo = true;
            skinTwoText.text = "Glass";
        }
        if (PlayerPrefs.GetInt("03_skin") == 1)
        {
            skinThree = true;
            skinThreeText.text = "Grass";
        }
        if (PlayerPrefs.GetInt("04_skin") == 1)
        {
            skinFour = true;
            skinFourText.text = "Lava";
        }
        if (PlayerPrefs.GetInt("05_skin") == 1)
        {
            skinFive = true;
            skinFiveText.text = "Ying Bang";
        }
        if (PlayerPrefs.GetInt("06_skin") == 1)
        {
            skinSix = true;
            skinSixText.text = "Rainbow";
        }
        if (PlayerPrefs.GetInt("07_skin") == 1)
        {
            skinSeven = true;
            skinSevenText.text = "Camo";
        }
        if (PlayerPrefs.GetInt("08_skin") == 1)
        {
            skinEight = true;
            skinEightText.text = "Void";
        }
        if (PlayerPrefs.GetInt("09_skin") == 1)
        {
            skinNine = true;
            skinNineText.text = "Gay";
        }
        if (PlayerPrefs.GetInt("10_skin") == 1)
        {
            skinTen = true;
            skinTenText.text = "Basket";
        }
        if (PlayerPrefs.GetInt("11_skin") == 1)
        {
            skinEleven = true;
            skinElevenText.text = "Bubbles";
        }
        if (PlayerPrefs.GetInt("12_skin") == 1)
        {
            skinTwelve = true;
            skinTwelveText.text = "Jetblack";
        }
        if (PlayerPrefs.GetInt("13_skin") == 1)
        {
            skinThirteen = true;
            skinThirteenText.text = "Slime";
        }
        if (PlayerPrefs.GetInt("14_skin") == 1)
        {
            skinFourteen = true;
            skinFourteenText.text = "Blue";
        }
        if (PlayerPrefs.GetInt("15_skin") == 1)
        {
            skinFifthteen = true;
            skinFifthteenText.text = "Steel";
        }
        if (PlayerPrefs.GetInt("16_skin") == 1)
        {
            skinSixteen = true;
            skinSixteenText.text = "Brozne";
        }
        if (PlayerPrefs.GetInt("17_skin") == 1)
        {
            skinSeventeen = true;
            skinSeventeenText.text = "Silver";
        }
        if (PlayerPrefs.GetInt("18_skin") == 1)
        {
            skinEightteen = true;
            skinEightteenText.text = "Shaped Glass";
        }
        if (PlayerPrefs.GetInt("19_skin") == 1)
        {
            skinNineteen = true;
            skinNineteenText.text = "Gold";
        }

        points = PlayerPrefs.GetInt("Points");
        scoreText.text = "Points: " + points.ToString();

    }
}
