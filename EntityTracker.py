#Program that tracks time spent on a task
import time
import os
import sys
import datetime
import json
import argparse

def main():
    parser = argparse.ArgumentParser(description='Track time spent on a task')
    parser.add_argument('-s', '--start', action='store_true', help='Start tracking time')
    parser.add_argument('-e', '--end', action='store_true', help='End tracking time')
    parser.add_argument('-l', '--list', action='store_true', help='List all tasks')
    parser.add_argument('-d', '--delete', action='store_true', help='Delete a task')
    parser.add_argument('-t', '--task', type=str, help='Task name')
    parser.add_argument('-p', '--pause', action='store_true', help='Pause tracking time')
    parser.add_argument('-r', '--resume', action='store_true', help='Resume tracking time')
    parser.add_argument('-sv', '--save', action='store_true', help='Save tasks')
    args = parser.parse_args()

    if args.start:
        start_tracking(args.task)
    elif args.end:
        end_tracking(args.task)
    elif args.list:
        list_tasks()
    elif args.delete:
        delete_task(args.task)
    elif args.pause:
        pause_tracking(args.task)
    elif args.resume:
        resume_tracking(args.task)
    elif args.save:
        save_tasks()
    else:
        parser.print_help()
        
def start_tracking(task):
    if not task:
        print("Please provide a task name")
        return
    if os.path.exists('tasks.json'):
        with open('tasks.json', 'r') as f:
            tasks = json.load(f)
    else:
        tasks = {}
    if task in tasks:
        print("Task already exists")
        return
    tasks[task] = {'start': time.time()}
    with open('tasks.json', 'w') as f:
        json.dump(tasks, f)
    print(f"Started tracking {task}")
    
def end_tracking(task):
    if not task:
        print("Please provide a task name")
        return
    if os.path.exists('tasks.json'):
        with open('tasks.json', 'r') as f:
            tasks = json.load(f)
    else:
        tasks = {}
    if task not in tasks:
        print("Task does not exist")
        return
    tasks[task]['end'] = time.time()
    with open('tasks.json', 'w') as f:
        json.dump(tasks, f)
    print(f"Ended tracking {task}")
    
def list_tasks():
    if os.path.exists('tasks.json'):
        with open('tasks.json', 'r') as f:
            tasks = json.load(f)
    else:
        tasks = {}
    for task, times in tasks.items():
        if 'end' in times:
            print(f"{task}: {datetime.timedelta(seconds=times['end'] - times['start'])}")
        else:
            print(f"{task}: {datetime.timedelta(seconds=time.time() - times['start'])}")
            
def delete_task(task):
    if not task:
        print("Please provide a task name")
        return
    if os.path.exists('tasks.json'):
        with open('tasks.json', 'r') as f:
            tasks = json.load(f)
    else:
        tasks = {}
    if task not in tasks:
        print("Task does not exist")
        return
    del tasks[task]
    with open('tasks.json', 'w') as f:
        json.dump(tasks, f)
    print(f"Deleted {task}")
    
#function to temporarily stop the count of a task
def pause_tracking(task):
    if not task:
        print("Please provide a task name")
        return
    if os.path.exists('tasks.json'):
        with open('tasks.json', 'r') as f:
            tasks = json.load(f)
    else:
        tasks = {}
    if task not in tasks:
        print("Task does not exist")
        return
    tasks[task]['end'] = time.time()
    with open('tasks.json', 'w') as f:
        json.dump(tasks, f)
    print(f"Paused tracking {task}")
    
#function to resume the count of a task
def resume_tracking(task):
    if not task:
        print("Please provide a task name")
        return
    if os.path.exists('tasks.json'):
        with open('tasks.json', 'r') as f:
            tasks = json.load(f)
    else:
        tasks = {}
    if task not in tasks:
        print("Task does not exist")
        return
    tasks[task]['start'] = time.time()
    with open('tasks.json', 'w') as f:
        json.dump(tasks, f)
    print(f"Resumed tracking {task}")
    
#function to save the list of tasks to a file
def save_tasks():
    if os.path.exists('tasks.json'):
        with open('tasks.json', 'r') as f:
            tasks = json.load(f)
    else:
        tasks = {}
    with open('tasks.json', 'w') as f:
        json.dump(tasks, f)
    print("Tasks saved")
    
if __name__ == '__main__':
    main()
    


#To start tracking a task
#python3 track_time.py -s -t "Task1"

#To end tracking a task
#python3 track_time.py -e -t "Task1"

#To list all tasks
#python3 track_time.py -l

#To delete a task
#python3 track_time.py -d -t "Task1"

