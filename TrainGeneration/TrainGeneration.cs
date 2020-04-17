using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainGeneration : MonoBehaviour
{

    public Transform DefaultPosition;
    public Transform ParentObject;
    public GameObject DefaultTrain;
    public GameObject DataCell;

    private float _widthCell;
    private float _heightCell;
    private int _AngleRefraction = 3;
    private float _offsetTrainGEnerationsXAxias;
    private float _offsetTrainGEnerationsYAxias = 0f;
    private string _typeObjectGenerate;
    private Vector3 _positionObjectGenerate = new Vector3(1,1,1);
    private int _minRangeToNextDirection = 3;
    private float cooeficient = 1.45f;
    private int _prevYAxias = 0;
    private int _currentYAxias = 0;
    private int _nextYAxias = 0;

    private void GenerationsTrainMain() 
    {
        for (int _xIterWidth = 0; _xIterWidth < 50; _xIterWidth++) {
        
            OffsetXAxias(_xIterWidth);
            OffsetYAxias(_xIterWidth);
            setTypeObject();
            CreateTrainObjectXAxias(_xIterWidth);
            // for (int _yIterHeight = 0; _yIterHeight < 20; _yIterHeight++)
            // {
            //     CreateTrainObjectYAxias(_yIterHeight);
            // }
        }
    }

    // private void CreateTrainObjectYAxias(int _yIterHeight)
    // {
    //     float _offsetY = _yIterHeight * ( _heightCell / cooeficient);
    //     var pos = new Vector3(_offsetTrainGEnerationsXAxias,_offsetTrainGEnerationsYAxias -= _offsetY, 0);
    //     Instantiate(switchTypeObjectToGenerate(), pos, Quaternion.identity,ParentObject);
    // }

    private void CreateTrainObjectXAxias(int _xIterWidth)
    {
        var pos = new Vector3(_offsetTrainGEnerationsXAxias,_offsetTrainGEnerationsYAxias, 0);
        Instantiate(switchTypeObjectToGenerate(), pos, Quaternion.identity, ParentObject);
    }

    private void setTypeObject()
    {   
        _typeObjectGenerate = "test";
    }

    private void OffsetXAxias(int _xIterWidth)
    {
        _offsetTrainGEnerationsXAxias += (_widthCell / cooeficient);
    }

    private void OffsetYAxias(int _xIterWidth)
    {   
        float _resultsOffsetAndGameObjectsController = GenerateOffset();
        // if(_xIterWidth % 2 == 0) 
        // {
            _offsetTrainGEnerationsYAxias = _resultsOffsetAndGameObjectsController;
            //((_randomDirectionToGenerate * _heightCell) / cooeficient);
        // }
        // else 
        // {
        //     _offsetTrainGEnerationsYAxias = 0;
        // }
    }


    private float GenerateOffset()
    {
        int _randomDirectionToGenerate = Random.Range(-3,3);
        switch (switch_on)
        {
            
            default:
        }
    }

    private GameObject switchTypeObjectToGenerate()
    {
        return DefaultTrain;
    }
    // Start is called before the first frame update
    void Start()
    {
        _heightCell = DataCell.GetComponent<Transform>().localScale.y;
        _widthCell  = DataCell.GetComponent<Transform>().localScale.x;
        GenerationsTrainMain();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
