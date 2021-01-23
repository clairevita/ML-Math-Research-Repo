public class Level : MonoBehaviour
{
    //"Level" as in difficulty level. Currently this is only 4 difficulty levels: 1,2,3,4. If the player meets a threshold, their difficulty level increases. 
    public int selectedLevel;

    //The game checks these two integers as the numbers to be inputted into the math equation
    public int firstGen;
    public int secondGen;

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<CreateMath>().rightCounter == 25)
        {
            selectedLevel = 4;
        }
        if (GetComponent<CreateMath>().rightCounter == 17)
        {
            selectedLevel = 3;
        }
        if (GetComponent<CreateMath>().rightCounter == 9)
        {
            selectedLevel = 2;
        }
        if (GetComponent<CreateMath>().rightCounter == 0)
        {
            selectedLevel = 1;
        }
        if (GetComponent<CreateMath>().answered == true)
        {
            if (selectedLevel == 1)
            {
                firstGen = Random.Range(0, 4);
                secondGen = Random.Range(0, 4);
            }
            if (selectedLevel == 2)
            {
                firstGen = Random.Range(5, 9);
                secondGen = Random.Range(5, 9);
            }
            if (selectedLevel == 3)
            {
                firstGen = Random.Range(10, 14);
                secondGen = Random.Range(10, 14);
            }
            if (selectedLevel == 4)
            {
                firstGen = Random.Range(15, 20);
                secondGen = Random.Range(15, 20);
            }
        }
    }

   
}
