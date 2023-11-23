using System.Collections.Generic;
using System.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game.Scripts.Play
{
    public class CommandManager : SerializedMonoBehaviour
    {
       [SerializeField]private IEntity entity;
       [SerializeField]private ICommand currentCommand;
       [SerializeField]private List<ICommand> commands;

        private readonly CommandHandler _commandHandler = new();

        private bool _isCommandProcessing;

        private void Start()
        {
            entity = GetComponent<IEntity>();
            currentCommand = HeroCommand.Create<IdleCommand>(entity);

            commands = new List<ICommand>()
            {
                HeroCommand.Create<IdleCommand>(entity),
                HeroCommand.Create<DropKick>(entity),
                HeroCommand.Create<FlyingKneePunchCombo>(entity),
                HeroCommand.Create<GreatSwordJumpAttack>(entity),
                HeroCommand.Create<GreatSwordSlash>(entity),
                HeroCommand.Create<JumpAttack>(entity),
                HeroCommand.Create<SittingClap>(entity),
                HeroCommand.Create<StandingUp>(entity),
            };
        }

        private async Task HandleCommand(List<ICommand> inputs)
        {
            _isCommandProcessing = true;
            await _commandHandler.HandleCommand(inputs);
            _isCommandProcessing = false;
        }


        private void Update()
        {
            if (_isCommandProcessing)
            {
                return;
            }

            Logic();
        }

        private void Logic()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                var rnd = Random.Range(0, commands.Count);
                currentCommand = commands[rnd];
                var handleCommand = HandleCommand(new List<ICommand>() { currentCommand });
                Debug.Log("Task Processing : " + handleCommand.Status);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                    var handleCommand = HandleCommand(commands);
                    Debug.Log("Task Processing : " + handleCommand.Status);
            }

        }
    }


    public class CommandHandler
    {
        public async Task HandleCommand(List<ICommand> inputs)
        {
            foreach (var command in inputs)
            {
                await command.Execute();
            }
        }
    }
}