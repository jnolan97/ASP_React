﻿import React, { useState, useRef } from 'react';
import styled from 'styled-components';
import Task from './Task.jsx';
import { Droppable } from 'react-beautiful-dnd';

const Container = styled.div`
    margin: 8px;
    border: 1px solid lightgrey;
    border-radius: 2px;
    width: 30%;
    display: inline-block;
    flex-direction: column;
`;
const Title = styled.h3`
    padding: 8px;
    transition: 0.5s all ease-out;
    &:hover {
        transform: translateY(-3px);
        box-shadow: 0 4px 17px rgba(0, 0, 0, 0.35);
    }
`;
const TaskList = styled.div`
    padding: 8px;
    flex-grow: 1;
    min-height: 200px;

    
`;

export default function Column({ column, names }) {
    const [task, setTask] = useState(names)
    const childRef = useRef();

    const handleRemoveItem = () => {
        const { id } = names[0].id;
        console.log('d', id)
        names.splice(id, 1)
        console.log('id', id)
        setTask([...names]);
    };
    return (
        <Container>
            <Title>
                {column}
            </Title>
            <Droppable droppableId={column}>
                {(provided, snapshot) => (

                    
                    <TaskList
                        {...provided.droppableProps}
                        {...snapshot.isDraggingOver}
                        ref={provided.innerRef}
                        style={{ backgroundColor: snapshot.isDraggingOver ? 'lightgreen' : 'white' }}
                    >
                        <div className='tasks'>
                            {console.log('names', names)}
                            {names.map((task, index) => <Task key={task.id} task={task} index={index} parent={() => handleRemoveItem()} />)}
                            {/* {names.map((btn,index) => <button key={task.id} index={index} onClick={() => setTask(handleRemoveItem())}>X</button>)} */}
                            {provided.placeholder}
                            {/* {props.tasks.map((task,index) => <Box onClick={props}>X</Box>)} */}
                            {/* <div onClick={() => props.tasks.splice(props.tasks,1)}>Delete</div> */}
                        </div>
                    </TaskList>

                )}
            </Droppable>
        </Container>
    );
}