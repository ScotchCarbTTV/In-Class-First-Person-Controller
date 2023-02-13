using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthFirstSearch : MonoBehaviour
{
    //list variable for stack

    //list variable for path
    private List<Node> pathList = new List<Node>();

    //list of all nodes in the graph

    //variable for the current node

    //variable for starting node

    //variable for destination node

    // Start is called before the first frame update
    void Start()
    {
        //find all available nodes and add them to the node list
    }

    // Update is called once per frame
    void Update()
    {
        //detect user input for triggering the pathfinding
    }

    public List<Node> FindPath(Node startNode, Node targetNode)
    {
        //set currentNode as startNode

        //add currentNode to stack

        //set local variable 'found' to false

        //initiate while loop to continue so long as 'found' is false
        //check if currentNode is the target node
        //if it isn't, continue the loop
        //otherwise set 'found' to true and break the loop

        //for each neighbour of current node
        //check if it's on the stack
        //check if it's already searched
        //if neither is true, add neighbour to stack and set currentNode as parent

        //set currentNode to 'searched'
        //remove currentNode from stack

        //check if the stack is empty
        //yes: break loop and return null with error message as path doesn't exist
        //no: set last node in stack as currentNode
        //return to start of loop

        //if 'found' is true
        //add 'currentNode' to path
            //check if currentNode has parent
            //if it does, set parent as currentNode and continute loop
            //otherwise, return the path value        

        return null;
    }
}
