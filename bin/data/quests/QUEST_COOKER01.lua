QUEST_COOKER01 = {
	title = 'IDS_PROPQUEST_INC_001928',
	character = 'MaFl_Cooker01',
	start_requirements = {
		min_level = 1,
		max_level = 129,
		job = { 'JOB_VAGRANT', 'JOB_MERCENARY', 'JOB_ACROBAT', 'JOB_ASSIST', 'JOB_MAGICIAN', 'JOB_KNIGHT', 'JOB_BLADE', 'JOB_JESTER', 'JOB_RANGER', 'JOB_RINGMASTER', 'JOB_BILLPOSTER', 'JOB_PSYCHIKEEPER', 'JOB_ELEMENTOR' },
	},
	rewards = {
		gold = 0,
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_INC_001929',
			'IDS_PROPQUEST_INC_001930',
		},
		begin_yes = {
			'IDS_PROPQUEST_INC_001931',
		},
		begin_no = {
			'IDS_PROPQUEST_INC_001932',
		},
		completed = {
			'IDS_PROPQUEST_INC_001933',
		},
		not_finished = {
			'IDS_PROPQUEST_INC_001934',
		},
	}
}